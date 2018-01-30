import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders, HttpResponse} from '@angular/common/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/catch';
import {User} from '../entities/user';
import * as appGlobalsService from '../store/app-globals';

@Injectable()
export class UserService {
    constructor(private http: HttpClient ) {
    }

    getUser() {
        let promise = new Promise(() => {
            let url = appGlobalsService.baseAPIUrl + 'getUser/he/true';
            this.http.get(url)
                .toPromise()
                .then(
                    results => {
                        return results;
                    },
                );
        });
    }

    creatUser(user: User, type: boolean): any {
        let url = appGlobalsService.baseAPIUrl + 'createUser/he/true?' +
            '&mail=' + user.mail +
            '&firstName=' + user.firstName +
            '&lastName=' + user.lastName +
            '&childFirstName=' + user.childFirstName +
            '&childLastName=' + user.childLastName +
            '&nickName=' + user.nickName +
            '&profile=' + null +
            '&password=' + user.password +
            '&city=' + user.city +
            '&build=' + user.build +
            '&streat=' + user.street +
            '&phone=' + user.phone +
            '&isAdministrator=' + type +
            '&groupId=' + appGlobalsService.getCurrentGroup().groupId;
        return this.http.get(url)
            .toPromise();
    }
}