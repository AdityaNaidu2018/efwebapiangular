import { Component, OnInit } from '@angular/core';
import { IEmployee } from '../iemployee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employees: IEmployee[];
  employee: IEmployee = { id: null, name: null, age: null, isPermanent: false };
  add: boolean = false;
  form: boolean = false;

  constructor(private employeeservice: EmployeeService) {
  }

  TrackByEmployeeCode(index: number, employee: IEmployee): number {
    return employee.id;
  }



  AddEmployee() {
    console.log(this.employee);
    if (this.add == true) {
      this.employeeservice.AddEmployee(this.employee).subscribe();
    } else if (this.add == false) {
      this.employeeservice.updateEmployee(this.employee.id, this.employee).subscribe();
    }
    
    //this.GetAllEmployee();
    this.add = false;
    this.form = false;
    this.employee = { id: null, name: null, age: null, isPermanent: false };
  }

  GetAllEmployee(): void {
    this.employeeservice.GetAllEmployees().subscribe((data: IEmployee[]) => {
      this.employees = data;
      console.log(data);
    });
  }

  DeleteEmployee(id: number): void {
    console.log('called');
    this.employeeservice.DeleteEmployeeById(id).subscribe();
    //this.employees = null;
    //this.GetAllEmployee();
  }

  UpdateEmployee(employee: IEmployee) {
    this.form = true;
    this.add == false;
    this.employee = employee;
  }

  ngOnInit() {
    //this.employeeservice.DeleteEmployeeById().subscribe();
  }

}
