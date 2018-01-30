import {Component, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
    selector: 'app-look-for-friends',
    templateUrl: './look-for-friends.component.html',
    styleUrls: ['./look-for-friends.component.scss']
})
export class LookForFriendsComponent implements OnInit {

    constructor(private http: HttpClient) {
    }

    inputAddress = 'רבי עקיבא 122 בני ברק'
    API_KEY = 'AIzaSyAftTULF-1UvfWrffosDlIChTWfhN_EqRU'
    API_URL = `https://maps.googleapis.com/maps/api/geocode/json?key=AIzaSyAftTULF-1UvfWrffosDlIChTWfhN_EqRU&address=`;
    dir = undefined;
    ngOnInit() {
        console.log(this.findFromAddress('בית וגן ירושלים'));
        this.getDirection();
    }

    findFromAddress(address: string): any {
        let compositeAddress = [address];
        let url = `${this.API_URL}${compositeAddress.join(',')}`;

        return this.http.get(url).toPromise().then(
            results => {
                console.log(results);
            })
    }

    public getDirection() {
        this.dir = {
            origin: { lat: 24.799448, lng: 120.979021 },
            destination: { lat: 24.799524, lng: 120.975017 }
        }
    }

    title: string = 'My first AGM project';
    lat: number = 31.768379;
    lng: number = 35.184947
}
