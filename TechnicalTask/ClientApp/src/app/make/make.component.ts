import { Component } from '@angular/core';
import { SharedService } from '../shared.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
    selector: 'app-make',
    templateUrl: './make.component.html',
    styleUrls: ['../finance-rate/finance-rate.component.css']
})
export class MakeComponent {
    constructor(private SharedService: SharedService) { }
    makeForm: FormGroup;
    EventValue: any = "Save";
    submitted: any = false;
    makes: any[];
    ngOnInit(): void {
        this.getMakes();
        this.makeForm = new FormGroup({
            Id: new FormControl(0),
            Name: new FormControl("", [Validators.required]),
        })
    }
    getMakes() {
        this.SharedService.getMakes().subscribe((data: any[]) => {
            this.makes = data;
            console.log(this.makes);
        })
    }
    Save() {
        this.submitted = true;
        if (this.makeForm.invalid) {
            return;
        }
        this.SharedService.saveMake(this.makeForm.value).subscribe((data: any[]) => {
            this.resetFrom();
        })
    }
    deleteData(id) {
        this.SharedService.deleteData(id).subscribe((data: any[]) => {
            this.getMakes();
        })
    }
    resetFrom() {
        this.getMakes();
        this.makeForm.reset();
        this.submitted = false;
    }
    Update() {
        this.submitted = true;

        if (this.makeForm.invalid) {
            return;
        }
        this.SharedService.update(this.makeForm.value).subscribe((data: any[]) => {
            this.resetFrom();
        })
    }

    EditData(Data) {
        this.makeForm.controls["Id"].setValue(Data.Id);
        this.makeForm.controls["Name"].setValue(Data.Name);
        this.EventValue = "Update";
    }

}

