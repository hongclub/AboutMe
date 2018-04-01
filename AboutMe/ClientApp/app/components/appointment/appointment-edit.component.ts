import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router'; 
import { Http } from '@angular/http';
import { Location } from '@angular/common';

@Component({
    selector: 'appointment-edit',
    templateUrl: './appointment-edit.component.html'
})
export class AppointmentEditComponent {
    public appointment: Appointment;
    public user: string;

    // for company rating drop down
    objectTypes: any = [
        { id: '0', name: '-- Please Select --' },
        { id: 'Job', name: 'Job' }
    ];
    selectedObjectType = '0';

    types: any = [
        { id: '0', name: '-- Please Select -- ' },
        { id: 'Phone Interview', name: 'Phone Interview' },
         { id: 'OnSite Interview', name: 'OnSite Interview' }
    ];
    selectedType = '0';
    

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private location: Location) {
        // get id from url
        const id = this.route.snapshot.paramMap.get('id');

        if (id == null) {
            this.appointment = new Appointment();
            //    (0, 'test', 'test', 'test', 'test', 'test', 'test', 'test');
            //{
            //    id = 0,
            //    title = 'test';
            //    comment = comment;
            //    rate = rate;
            //    companyRate = companyRate;
            //    category = category;
            //    createdDate = createdDate;
            //};

        }
        else {
        this.http.get(this.baseUrl + 'api/Appointment/' + id).subscribe(result => {
            this.appointment = result.json() as Appointment;
            this.selectedObjectType = this.appointment.objectType;
            this.selectedType = this.appointment.type;
            }, error => console.error(error));
        }
    }


    goBack(): void {
        this.location.back();
    }

    save(): void {

        console.log(this.appointment);
        let currentDate = new Date();
        if (this.appointment.id == null)
        {
            this.appointment.createdDate = currentDate;
            this.http.post(this.baseUrl + 'api/Appointment', this.appointment).subscribe(() => this.goBack()); 
        }
        else
        {
            this.appointment.modifiedDate = currentDate;
            this.http.put(this.baseUrl + 'api/Appointment', this.appointment).subscribe(() => this.goBack());       
        }
    }

    changeObjectTypeDropdown(id: string): void {
        this.appointment.objectType = id.toString();
        console.log(id);
    }

    changeTypeDropdown(id: string): void {
        this.appointment.type = id.toString();
        console.log(id);
    }

}


export class Appointment {
    id: Number;
    title: string;
    description: string;
    objectId: Number;
    objectType: string;
    type: string;
    fromDate: Date;
    toDate: Date;
    modifiedDate: Date;
    createdDate: Date
}



