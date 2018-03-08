import { Component, Inject} from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'user',
    templateUrl: './user.component.html'
})
export class UserComponent {
    public user1: UserObject;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/User/UserDetail').subscribe(result => {
            this.user1 = result.json() as UserObject;
        }, error => console.error(error));
    }

}


interface UserObject {
    Id: number; 
    UserName: string;
    FirstName: string;
    LastName: string;
    EmailAddress: string;
    PhoneNumber: string;
}


