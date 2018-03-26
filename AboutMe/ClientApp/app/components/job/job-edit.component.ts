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

    // for overall rating drop down
    ratings: any = [
        { id: 1, name: '1' },
        { id: 2, name: '2' },
        { id: 3, name: '3' },
        { id: 4, name: '4' },
        { id: 5, name: '5' }
    ];
    selectedRating = 2;

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
        let currentDate = new Date();

        if (this.job.id == null)
        {
            this.job.createdDate = currentDate;
            this.http.post(this.baseUrl + 'api/Job', this.job).subscribe(() => this.goBack()); 
        }
        else
        {
            this.job.modifiedDate = currentDate;
            this.http.put(this.baseUrl + 'api/Job', this.job).subscribe(() => this.goBack());       
        }
    }


    changeRatingDropdown(id: number): void {
        //const NAME = this.list.find((item: any) => item.id === +id).name;
        this.job.rating = id.toString();
        console.log('debug rating:' + this.job.rating);
    }
}



export class  Job {
    id: Number;
    title: string;
    description: string;
    comment: string;
    rating: string;
    companyRating: string;
    category: string;
    modifiedDate: Date
    createdDate: Date;
   

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



