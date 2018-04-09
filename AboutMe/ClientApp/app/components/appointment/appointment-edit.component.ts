import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router'; 
import { Http } from '@angular/http';
import { Location } from '@angular/common';
import { Appointment } from './appointment';
import { Observable } from 'rxjs/Rx';  

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

    selectedJob: Number = 0;

    public jobs: tbl_job; 
    

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private location: Location) {
        // get id from url
        const id = this.route.snapshot.paramMap.get('id');

        if (id == null) {
            this.appointment = new Appointment();
        }
        else {
        this.http.get(this.baseUrl + 'api/Appointment/' + id).subscribe(result => {
            this.appointment = result.json() as Appointment;
            this.selectedObjectType = this.appointment.objectType;
            this.selectedType = this.appointment.type;
            this.selectedJob = this.appointment.objectId;
            }, error => console.error(error));
        }

        this.http.get(this.baseUrl + 'api/job/').subscribe(result => {
            this.jobs = result.json() as tbl_job;
            console.log('job: ' + this.jobs);
        }, error => console.error(error));
    }

   /*     
    getJobs(): Observable<tbl_job[]> {
        return this.http.get('api/Job/').subscribe(res => res.json());
    }
    */


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

    changeJobDropdown(id: Number): void {
        this.appointment.objectId = id;
        console.log('objectId' + id);
    }

}


export class tbl_job {
    //JobID: number;
    //JobTitle: string;

    id: Number;
    title: string;
    description: string;
    comment: string;
    rating: string;
    companyRating: string;
    category: string;
    modifiedDate: Date;
    createdDate: Date;

} 



