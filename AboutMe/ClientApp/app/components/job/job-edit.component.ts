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

        if (id == null) {
            this.job = new Job();
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
        this.http.get(this.baseUrl + 'api/Job/' + id).subscribe(result => {
            this.job = result.json() as Job;
            }, error => console.error(error));
        }
    }


    goBack(): void {
        this.location.back();
    }

    save(): void {

        if (this.job.id == null)
        {
            this.http.post(this.baseUrl + 'api/Job', this.job).subscribe(() => this.goBack()); 
        }
        else
        {
            this.http.put(this.baseUrl + 'api/Job', this.job).subscribe(() => this.goBack());       
        }
    }

}



export class  Job {
    id: Number;
    title: string;
    descrption: string;
    comment: string;
    rate: string;
    companyRate: string;
    category: string;
    createdDate: string

    //constructor(id: number,
    //    title: string,
    //    descrption: string,
    //    comment: string,
    //    rate: string,
    //    companyRate: string,
    //    category: string,
    //    createdDate: string
    //    ) {
    //    this.id = id;
    //    this.title = title;
    //    this.comment = comment;
    //    this.rate = rate;
    //    this.companyRate = companyRate;
    //    this.category = category;
    //    this.createdDate = createdDate;

    // }
}



