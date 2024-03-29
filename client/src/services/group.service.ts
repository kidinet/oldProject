import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders, HttpResponse} from '@angular/common/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/catch';
import {Group} from '../entities/group';
import {UserService} from '../services/user.service';
import * as appGlobalsService from '../store/app-globals';
@Injectable()
export class GroupService {
    constructor(private http: HttpClient, private userService: UserService) {
    }


    createGroup(group: Group): any {
        this.userService.findFromAddress(`${group.groupCity} ${group.groupStreet} ${group.groupBuild}`).then(
            results => {
                if (results.status === 'OK') {
                    group.latitude = results.results[0].geometry.location.lat;
                    group.longitude = results.results[0].geometry.location.lng;
                }
            });
        const url = `${appGlobalsService.baseAPIUrl}createGroup/he/true?name='
           ${group.groupName}
            &city='${group.groupCity}
            &street='${group.groupCity}
            &build='${group.groupBuild}
            &phone='${group.groupPhone}
            &mail='${group.groupMail}
            &fax='${group.groupFax}
            &latitude=${group.latitude}
            &longitude=${group.longitude}`
        return this.http.get(url)
            .toPromise();
    }

    updateGroup(group: Group): any {
        const url = `${appGlobalsService.baseAPIUrl}updateGroup/he/true?
             id=${group.groupId}
            &name=${group.groupName}
            &city=${group.groupCity}
            &street=${group.groupCity}
            &build=${group.groupBuild}
            &phone=${group.groupPhone}
            &mail='${group.groupMail}
            &fax='${group.groupFax}`
        return this.http.get(url)
            .toPromise();
    }
}
