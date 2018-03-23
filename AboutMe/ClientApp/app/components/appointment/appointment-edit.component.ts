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
            }, error => console.error(error));
        }
    }


    goBack(): void {
        this.location.back();
    }

    save(): void {

        if (this.appointment.id == null)
        {
            this.http.post(this.baseUrl + 'api/Appointment', this.appointment).subscribe(() => this.goBack()); 
        }
        else
        {
            this.http.put(this.baseUrl + 'api/Appointment', this.appointment).subscribe(() => this.goBack());       
        }
    }

}



export class Appointment {
    id: Number;
    title: string;
    descrption: string;
    objectId: Number;
    objectType: string;
    date: string;
    createdDate: string
}



