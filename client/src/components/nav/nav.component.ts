import {Component, OnInit} from '@angular/core';
import {PersonalAreaSettingsComponent} from '../personal-area/personal-area-settings/personal-area-settings.component';
import {ConfirmPasswordComponent} from '../personal-area/confirm-password/confirm-password.component'
import {MatDialog} from '@angular/material';

@Component({
    selector: 'app-nav',
    templateUrl: './nav.component.html',
    styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

    constructor(public personalSettings: MatDialog, public confirmPassword: MatDialog) {
    }

    isPersonalAreaNavOpen = false;

    ngOnInit() {
    }

    openPersonalSettings() {
        const addNewImageDialogRef = this.personalSettings.open(PersonalAreaSettingsComponent, {});
    }

    openConfirmPassword() {
        const addNewImageDialogRef = this.confirmPassword.open(ConfirmPasswordComponent, {});
    }

    toggleSettings() {
        this.isPersonalAreaNavOpen = !this.isPersonalAreaNavOpen;
    }
}
