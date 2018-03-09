import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'whatever',
    templateUrl: './job-edit.component.html'
})
export class JobEditComponent {
    public job: Job;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Job/JobDetail').subscribe(result => {
            this.job = result.json() as Job;
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



