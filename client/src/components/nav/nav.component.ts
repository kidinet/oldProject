import {Component, OnInit} from '@angular/core';

@Component({
    selector: 'app-nav',
    templateUrl: './nav.component.html',
    styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

    constructor() {
    }

    isPersonalAreaNavOpen = false;

    ngOnInit() {
    }

    togglePersonalAreaNav() {
        this.isPersonalAreaNavOpen = !this.isPersonalAreaNavOpen;
    }
}
