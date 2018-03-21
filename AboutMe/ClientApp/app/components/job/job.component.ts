import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'job',
    templateUrl: './job.component.html'
})
export class JobComponent {
    public jobs: Job[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Job').subscribe(result => {
            this.jobs = result.json() as Job[];
        }, error => console.error(error));
    }
}

interface Job {
    id: Number,
    title: string,
    descrption: string,
    comment: string,
    rate: string,
    companyRate: string,
    category: string,
    createdDate: string
}



