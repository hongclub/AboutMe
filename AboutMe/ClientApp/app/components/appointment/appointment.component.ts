import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'appointment',
    templateUrl: './appointment.component.html'
})
export class AppointmentComponent {
    public appointments: Appointment[];

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {
        http.get(baseUrl + 'api/Appointment').subscribe(result => {
            this.appointments = result.json() as Appointment[];
        }, error => console.error(error));
    }

    delete(id: string): void {
        this.http.delete(this.baseUrl + 'api/Appointment/' + id).subscribe(() => this.reload());
    }

    reload(): void {
        window.location.reload(true);       // TODO: need to use Angular instead 
    }
}

interface Appointment {
    id: Number,
    title: string,
    descrption: string,
    objectId: Number,
    objectType: string
    date: string,
    modifiedDate: Date,
    createdDate: Date
}



