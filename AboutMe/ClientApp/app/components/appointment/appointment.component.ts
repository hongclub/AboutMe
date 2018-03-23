import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'appointment',
    templateUrl: './appointment.component.html'
})
export class AppointmentComponent {
    public appointments: Appointment[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Appointment').subscribe(result => {
            this.appointments = result.json() as Appointment[];
        }, error => console.error(error));
    }
}

interface Appointment {
    id: Number,
    title: string,
    descrption: string,
    objectId: Number,
    objectType: string
    date: string,
    createdDate: string
}



