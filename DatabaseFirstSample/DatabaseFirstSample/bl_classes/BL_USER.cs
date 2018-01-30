using DatabaseFirstSample.bl_classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstSample
{
    public class BL_User
    {
        public BL_User() { }
        
        public User getUser(string mail)
        {
            using (var db = new BloggingContext())
            {
                try
                {
                    var User= db.Users.FirstOrDefault(x => x.mail == mail);
                    return User;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Result<User> createUser(
            string mail,
            string firstName,
            string lastName,
            string childFirstName,
            string childLastName,
            string nickName,
            byte[] profile,
            string password,
            string city,
            string streat,
            int build,
            string phone,
            bool isAdiministrator,
            int groupId
            )
        {
            byte[] profile_;
            string varFilePath = "D:/Users/Gili/Pictures/aaa/vvv.jpg";
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    profile_ = reader.ReadBytes((int)stream.Length);
                }
            }

            using (var db = new BloggingContext())
            {
               
                string varPathToNewLocation = @"C:/pictures/aczcaa.jpg";
                byte[] blob= db.Users.FirstOrDefault(x => x.mail == "ghjghj@kytujkjk3333j.com").profile_;
                using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                fs.Write(blob, 0, blob.Length);
                User existentUser = db.Users.FirstOrDefault(x => x.mail == mail);
                if (existentUser != null)
                {
                    return new Result<User>(false, new User(),1);
                }
                try
                {
                    User User = new User(mail,
                    firstName,
                    lastName,
                    profile_,
                    password,
                    city,
                    streat,
                    build,
                    phone);
                    db.Users.Add(User);
                    db.UserInGroups.Add(new UserInGroup(groupId, mail, isAdiministrator,childFirstName,childLastName,nickName));
                    db.SaveChanges();
                        return new Result<User>(true,User);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }

    
}
