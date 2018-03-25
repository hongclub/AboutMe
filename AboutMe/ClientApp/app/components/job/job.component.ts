import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Location } from '@angular/common';

@Component({
    selector: 'job',
    templateUrl: './job.component.html'
})
export class JobComponent {
    public jobs: Job[];

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string, private location: Location) {
        http.get(baseUrl + 'api/Job').subscribe(result => {
            this.jobs = result.json() as Job[];
        }, error => console.error(error));
    }


    delete(id: string): void {
        this.http.delete(this.baseUrl + 'api/Job/' + id).subscribe(() => this.reload()); 
    }

    reload(): void {
        window.location.reload(true);       // TODO: need to use Angular instead 
    }
}

interface Job {
    id: Number,
    title: string,
    descrption: string,
    comment: string,
    rating: string,
    companyRating: string,
    category: string,
    modifiedDate: Date
    createdDate: Date
}



