import { Component, Inject} from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'user',
    templateUrl: './user.component.html'
})
export class UserComponent {
    public user: UserObject;

    constructor(http: Http, @Inject('BASE_URL') private baseUrl: string) {

        ////this.getUser();
        
        //// TODO: somehow this binding failed ... 
        //http.get(baseUrl + 'api/User/UserDetail').subscribe(result => {
        //    this.user = result.json() as UserObject; 
            
        //}, error => console.error(error));
       
        //console.error(this.user);


        // get id from url
        const id = 1;


        http.get(this.baseUrl + 'api/User/' + id).subscribe(result => {
            this.user = result.json() as UserObject;
        }, error => console.error(error));
        
    }

    /*
    getUser(): void {
        // this.user1.Id = 1234;
        this.user = new UserObject();
        this.user.Id = 98854;
        this.user.UserName = 'Tommy Lai';
        this.user.FirstName = 'Wai-Hong';
        this.user.LastName = 'Lai';
        this.user.EmailAddress = 'lai_tommy@hotmail.com';
        this.user.PhoneNumber = '949-374-3491';
    }
    */

    save(): void {

        // TODO: it will just update the value on the fire
        // this.user = new UserObject();
        this.user.id = 345345;
        this.user.userName = 'Tommy Lai2';
        this.user.firstName = 'Wai-Hong';
        this.user.lastName = 'Lai';
        this.user.emailAddress = 'lai_tommy@hotmail.com';
        this.user.phoneNumber = '949-374-3491';

        console.log(this.user);
    }

}


export class UserObject {
    id: number; 
    userName: string;
    firstName: string;
    lastName: string;
    emailAddress: string;
    phoneNumber: string;
}


