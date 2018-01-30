import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders, HttpResponse} from '@angular/common/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/catch';
import {Group} from '../entities/group';
import * as appGlobalsService from '../store/app-globals';
@Injectable()
export class GroupService {
    constructor(private http: HttpClient ) {
    }


    createGroup(group: Group): any {
        let url = appGlobalsService.baseAPIUrl + 'createGroup/he/true?name='
            + group.groupName +
            '&city=' + group.groupCity +
            '&street=' + group.groupCity +
            '&build=' + group.groupBuild +
            '&phone=' + group.groupPhone +
            '&mail=' + group.groupMail +
            '&fax=' + group.groupFax;
        return this.http.get(url)
            .toPromise();
    }
}
