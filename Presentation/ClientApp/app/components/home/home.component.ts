import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
	selector: 'home',
	templateUrl: './home.component.html'
})
export class HomeComponent {
	public forecasts: PersonModel[];

	constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
		http.get(baseUrl + 'api/Home/ShowTable').subscribe(result => {
			this.forecasts = result.json() as PersonModel[];
		}, error => console.error(error));
	}
}

interface PersonModel {
	PersonType: string;
	NameStyle: boolean;
	Title: string;
	FirstName: string;
	MiddleName: string;
	LastName: string;
	Suffix: string;
	EmailPromotion: number;
	AdditionalContactInfo: string;
	Demographics: string;
	ModifiedDate: Date;
}
