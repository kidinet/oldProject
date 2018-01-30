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
        this.imageSrc = e.target.value;
    }


    ngOnInit() {

    }

    createCanvasImage() {
        var reader = new FileReader();
        this.canvas.nativeElement.getContext("2d").drawImage(this.imageToCanvas.nativeElement, 10, 10)
        let toDataURL = this.canvas.nativeElement.toDataURL().replace(/^data:image\/(png|jpg);base64,/, '');
        this.apiService.addImageToGallery(toDataURL, this.subject);
        this.dialogRef.close();

    }

    // get imageSrc(){
    //
    //    return this.fileInput.nativeElement.value ? this.fileInput.value: '../../../assets/images/kinder-garden/kinder-garden-8.jpg';
    // }
}
