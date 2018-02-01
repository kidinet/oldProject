import {Component, Inject, OnInit, ViewChild} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material";
import {ApiService} from '../../../services/api.service'

@Component({
    selector: 'app-add-new-image',
    templateUrl: './add-new-image.component.html',
    styleUrls: ['./add-new-image.component.scss']
})
export class AddNewImageComponent implements OnInit {

    @ViewChild('imageToCanvas') imageToCanvas
    @ViewChild('canvas') canvas;
    subject = '';
    imageSrc = '../../../assets/images/kinder-garden/kinder-garden-8.jpg';

    constructor(public dialogRef: MatDialogRef<AddNewImageComponent>,
                @Inject(MAT_DIALOG_DATA) public data: any,
                private apiService: ApiService) {
    }

    setImageSrc(e) {
<<<<<<< HEAD
=======
<<<<<<< HEAD
        let oFReader = new FileReader();
        oFReader.readAsDataURL(e.target.files[0]);
        this.imageSrc = e.target.files[0];
        oFReader.onload = (oFREvent)=> {
            this.imageSrc = oFREvent.target['result'];
        };
     
    }
  

    ngOnInit() {
    
    }

    createCanvas(){
        var c = this.canvas.nativeElement;
        var context = c.getContext("2d");
        var img = this.imageToCanvas.nativeElement;
        context.drawImage(img,0,0,c.width,c.height);
        this.imageSrc=c.toDataURL();
=======
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
        const oFReader = new FileReader();
        oFReader.readAsDataURL(e.target.files[0]);
        this.imageSrc = e.target.files[0];
        oFReader.onload = (oFREvent) => {
            this.imageSrc = oFREvent.target['result'];
        };

    }


    ngOnInit() {

    }

    createCanvas() {
        var c = this.canvas.nativeElement;
        var context = c.getContext("2d");
        var img = this.imageToCanvas.nativeElement;
        context.drawImage(img, 0, 0, c.width, c.height);
        this.imageSrc = c.toDataURL();
<<<<<<< HEAD
=======
>>>>>>> 80086fcc5df8b4668ad26f755b2927e01d42c9c2
>>>>>>> 710ca7a32c33c7087359b3eab676d00da88e00fa
    }

    createImage() {
        let toDataURL = this.imageSrc.replace(/^data:image\/(png|jpg);base64,/, '');
        this.apiService.addImageToGallery(toDataURL, this.subject);
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
    }

    // get imageSrc(){
    //
    //    return this.fileInput.nativeElement.value ? this.fileInput.value: '../../../assets/images/kinder-garden/kinder-garden-8.jpg';
    // }
}
