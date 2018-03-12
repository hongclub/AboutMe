import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router'; 
import { Http } from '@angular/http';

@Component({
    selector: 'whatever',
    templateUrl: './job-edit.component.html'
})
export class JobEditComponent {
    public job: Job;
    public user: string;

    

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, private route: ActivatedRoute) {
        // get id from url
        const id = this.route.snapshot.paramMap.get('id');

        http.get(baseUrl + 'api/Job/JobDetail/' + id).subscribe(result => {
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



