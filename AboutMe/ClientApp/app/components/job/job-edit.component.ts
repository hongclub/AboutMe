import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router'; 
import { Http } from '@angular/http';
import { Location } from '@angular/common';

@Component({
    selector: 'whatever',
    templateUrl: './job-edit.component.html'
})
export class JobEditComponent {
    public job: Job;
    public user: string;

    

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private location: Location) {
        // get id from url
        const id = this.route.snapshot.paramMap.get('id');

        this.http.get(this.baseUrl + 'api/Job/JobDetail/' + id).subscribe(result => {
            this.job = result.json() as Job;
        }, error => console.error(error));
    }


    goBack(): void {
        this.location.back();
    }

    save(): void {
        this.http.post(this.baseUrl + 'api/Job/UpdateJob', this.job).subscribe(() => this.goBack());        
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



