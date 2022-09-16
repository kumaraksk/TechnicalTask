import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Injectable({
    providedIn: 'root'
})

export class SharedService {
    baseUrl = "https://localhost:44338";
    constructor(private http: HttpClient) { }
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }
    getFinanceRates() {
        return this.http.get(this.baseUrl + '/api/Finance/Finances');
    }
    getFinanceTypes() {
        return this.http.get(this.baseUrl + '/api/FinanceRateType/FinanceRateTypes');
    }
    saveMake(make) {
        return this.http.post(this.baseUrl + '/api/Make/Make', make);
    }
    getMakes() {
        return this.http.get(this.baseUrl + '/api/Make/Makes');
    }
    deleteData(id) {
        return this.http.delete(this.baseUrl + '/api/Make/Delete?id=' + id);
    }
    update(make) {
        return this.http.put(this.baseUrl + '/api/Make/Update',make);
    }

}