using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabaseFirstSample.bl_classes;
using System.IO;
using System.Net.Mail;
using System.Web;


namespace DatabaseFirstSample
{
    public class Bl_Group
    {

        public Result<Group> createGroup(string name, string city,string street, int build, string phone, string mail, string fax)
        {
            
            using (var db = new BloggingContext())
            {
                try
                {
                    Group group =new Group(name, city, street ,build, phone, mail, fax);
                    db.Groups.Add(group);
                    db.SaveChanges();
                    return new Result<Group>(true, group);
                     
                }
                catch (Exception ex)
                {
                    return new Result<Group>(false, 1);
                    throw ex;
                }
            } 
        }
        public int getManegarGroupId(string mail)
        {
            using (var db = new BloggingContext())
            {
                UserInGroup user = db.UserInGroups.FirstOrDefault(x => x.userMail == mail);
                if (user != null)
                    return user.groupId;
                return -1;
            }
        }
        /// <summary>
        /// the funcrion get subject,groupName,password and sand mai to the prant to join him to kidinet group.
        /// the function use the othe function PopulateBody to create html string for the emai.
        /// in the email, the prent gets Temporary password, and has to change it.
        /// </summary>
        /// <param name="recepientEmail"></param>
        /// <param name="subject"></param>
        /// <param name="groupName"></param>
        /// <param name="password"></param>
        public bool SendMail(List<UserInGroup> recepientEmails, string subject, string groupName)
        {
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                mail.From = new MailAddress("kidinet.group@gmail.com", "kidinet");
               
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("kidinet.group@gmail.com", "kidinet1234");
                foreach (UserInGroup recepientEmail in recepientEmails)
                {
                    MailAddress mailAdress = new MailAddress(recepientEmail.userMail, "kidinet");
                    mail.To.Add(mailAdress);
                    mail.Body = this.PopulateBody(groupName, recepientEmail.User.password_);
                    client.Send(mail);
                    mail.To.Remove(mailAdress);
                }
                
            }
            return true;
        }
        public string PopulateBody(string groupName, string password)
        {

            string body = string.Empty;
            using (StreamReader reader = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/mailToPrent.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{groupName}", groupName);
            body = body.Replace("{password}", password);
            return body;
        }

       public bool SendMailToPrent(int groupId)
        {
            using (var db = new BloggingContext())
            {
                try
                {
                    var recepientEmails = db.UserInGroups.Where(user => user.groupId == groupId).ToList();
                    string groupName = db.Groups.FirstOrDefault(group => group.id == groupId).name;
                    return SendMail(recepientEmails, "kidinet ברוכים הבאים ל", groupName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           
        }
    }
}
