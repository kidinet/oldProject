import {Component, Inject, OnInit} from '@angular/core';
import {FormBuilder, FormControl, Validators} from '@angular/forms';
import {FormValidateService} from '../../../services/form-validate.service'
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material";

@Component({
    selector: 'app-personal-area-settings',
    templateUrl: './personal-area-settings.component.html',
    styleUrls: ['./personal-area-settings.component.scss']
})
export class PersonalAreaSettingsComponent implements OnInit {

    constructor(private builder: FormBuilder,
                private formValidateService: FormValidateService,
                public dialogRef: MatDialogRef<PersonalAreaSettingsComponent>,
                @Inject(MAT_DIALOG_DATA) public data: any) {
    }

    // user for variables:
    firstName = new FormControl('', Validators.required)
    lastName = new FormControl('', Validators.required)
    childfirstName = new FormControl('', Validators.required)
    childlastName = new FormControl('', Validators.required)
    nickName = new FormControl('')
    userCity = new FormControl('', Validators.required)
    userStreet = new FormControl('', Validators.required)
    userBuild = new FormControl('', Validators.required)
    userPhone = new FormControl('', this.formValidateService.validatePhone)
    userMail = new FormControl('', this.formValidateService.validateEmail)
    password = new FormControl('', Validators.required)
    confirmPassword = new FormControl('', this.formValidateService.confirmPassword(this.password))

    createUserForm = this.builder.group({
        firstName: this.firstName,
        lastName: this.lastName,
        childfirstName: this.childfirstName,
        childlastName: this.childlastName,
        nickName: this.nickName,
        city: this.userCity,
        street: this.userStreet,
        build: this.userBuild,
        phone: this.userPhone,
        mail: this.userMail,
        password: this.password,
        confirmPassword: this.confirmPassword
    });

    createUserInGroupForm = this.builder.group({
        childfirstName: this.childfirstName,
        childlastName: this.childlastName,
        nickName: this.nickName,
    });

    ngOnInit() {
    }

    updateUser() {
        console.log(this.createUserForm.value);
    }
    updateUserInGroup() {
        console.log(this.createUserInGroupForm.value);
    }

}
