import {Component, Inject, OnInit, ViewChild, AfterContentInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material';
import {ApiService} from '../../../services/api.service';
import {ImagesService} from '../../../services/images.service';

@Component({
    selector: 'app-add-new-image',
    templateUrl: './add-new-image.component.html',
    styleUrls: ['./add-new-image.component.scss']
})
export class AddNewImageComponent implements OnInit {

    @ViewChild('imageToCanvas') imageToCanvas
    @ViewChild('canvas') canvas;
    subject = '';
    imageSrc = '';
    isLoading = false;
    resultMessage = ''

    constructor(public dialogRef: MatDialogRef<AddNewImageComponent>,
                @Inject(MAT_DIALOG_DATA) public data: any,
                private apiService: ApiService,
                public imagesService: ImagesService) {
<<<<<<< HEAD
    }

    setImageSrc(e) {




=======
    }

    ngOnInit() {

    }

    setImageSrc(e) {
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e8d63939b53e75abd69ca8cf7d8cd492f9ec89a2
        let oFReader = new FileReader();
        oFReader.readAsDataURL(e.target.files[0]);
        this.imageSrc = e.target.files[0];
        oFReader.onload = (oFREvent)=> {
            this.imageSrc = oFREvent.target['result'];
        };
     
    }
  

    ngOnInit() {
    
    }

<<<<<<< HEAD
=======
    createCanvas(){
        var c = this.canvas.nativeElement;
        var context = c.getContext("2d");
        var img = this.imageToCanvas.nativeElement;
        context.drawImage(img,0,0,c.width,c.height);
        this.imageSrc=c.toDataURL();
=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
=======
        this.resultMessage = '';
>>>>>>> 1f259a07baaa29f2b93360a007c60b83a2363708
        const oFReader = new FileReader();
        oFReader.readAsDataURL(e.target.files[0]);
        oFReader.onload = (oFREvent) => {
            this.imageSrc = oFREvent.target['result'];
        };
<<<<<<< HEAD

    }


    ngOnInit() {

    }
>>>>>>> e8d63939b53e75abd69ca8cf7d8cd492f9ec89a2

    createCanvas() {
        var c = this.canvas.nativeElement;
        var context = c.getContext("2d");
        var img = this.imageToCanvas.nativeElement;
        context.drawImage(img, 0, 0, c.width, c.height);
        this.imageSrc = c.toDataURL();
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
>>>>>>> e8d63939b53e75abd69ca8cf7d8cd492f9ec89a2
    }

    createImage() {
        let toDataURL = this.imageSrc.replace(/^data:image\/(png|jpg);base64,/, '');
        this.apiService.addImageToGallery(toDataURL, this.subject);
<<<<<<< HEAD

     

=======
<<<<<<< HEAD
        // this.dialogRef.close();
        this.createCanvas();
=======
<<<<<<< HEAD
       // this.dialogRef.close();
       this.createCanvas();
=======
        // this.dialogRef.close();
        this.createCanvas();
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
=======
>>>>>>> e8d63939b53e75abd69ca8cf7d8cd492f9ec89a2
        this.isLoading = true;
        setTimeout(() => {
            this.isLoading = false;
            this.imageSrc = this.imagesService.createCanvas(this.canvas, this.imageSrc);
        }, 50);
<<<<<<< HEAD
=======
    }

    createImage() {
        const toDataURL = this.canvas.nativeElement.toDataURL().replace(/^data:image\/(png|jpg);base64,/, '');
        this.isLoading = true;
       /* this.apiService.addImageToGallery(toDataURL, this.subject).then(result => {
            this.resultMessage = result.Success ? 'התמונה נוספה לאוסף התמונות שלך' : 'לא ניתך להוסיף תמונה זו';
            this.isLoading = false;
            const ctx = this.canvas.nativeElement.getContext('2d')
            ctx.setTransform(1, 0, 0, 1, 0, 0);
            ctx.clearRect(0, 0, this.canvas.nativeElement.width, this.canvas.nativeElement.height);
        });*/
>>>>>>> 1f259a07baaa29f2b93360a007c60b83a2363708
>>>>>>> e8d63939b53e75abd69ca8cf7d8cd492f9ec89a2
    }

}
