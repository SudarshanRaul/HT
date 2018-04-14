import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { DashboardService } from '../../services/dashboardservice.service'
//import { EmployeeService } from '../../services/empservice.service'

@Component({
    selector: 'fetchcandidate',
    templateUrl: './fetchcandidate.component.html',
    styleUrls: ['./fetchcandidate.component.css']
})
export class FetchCandidateComponent {
    public candidateList: CandidateData[];

    constructor(public http: Http, private _router: Router, private _dashboardService: DashboardService) {
        this.getCandidates();
    }
    getCandidates() {
        this._dashboardService.getCandidates().subscribe(
            data => this.candidateList = data
        )
    }
    //delete(employeeID) {
    //    var ans = confirm("Do you want to delete customer with Id: " + employeeID);
    //    if (ans) {
    //        this._employeeService.deleteEmployee(employeeID).subscribe((data) => {
    //            this.getEmployees();
    //        }, error => console.error(error))
    //    }
    //}
}
interface CandidateData {
    candidateId: number;
    candidateName: string;
    phone: string;
    }