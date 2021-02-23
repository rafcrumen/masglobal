import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { EmployeeData } from './employee-data.model';
import { EmployeeDataService } from './employee-data.service';

@Component({
  selector: 'employee-data',
  templateUrl: './employee-data.component.html',
  styleUrls: ['./employee-data.component.css']
})
export class EmployeeDataComponent implements OnInit {
  form: FormGroup;
  employees: EmployeeData[];
  employee: EmployeeData;
  isShowMessage:boolean;
  constructor(private service: EmployeeDataService) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      id: new FormControl("")});
  }

  getData(){
    this.isShowMessage = true;
    this.employee = null;
    this.employees = null;
    const ctrlId = (this.form as FormGroup).controls?.id;
    if (ctrlId.value) {
      this.service.getById(ctrlId.value).subscribe((data) => {
        if (data){
          this.employee = data;
        }
      });
    } else {
      this.service.get().subscribe((data) => {
        if (data){
          this.employees = data;
        }
      });
    }
  }
}
