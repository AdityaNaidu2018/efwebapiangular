import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IEmployee } from './iemployee';



@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  GetAllEmployees(){
    return this.http.get("http://localhost:59421/api/Employee/GetAllEmployee");
  }

  DeleteEmployeeById(id: number) {
    return this.http.delete("http://localhost:59421/api/Employee/DeleteEmployee/" + id);
  }

  AddEmployee(employee: IEmployee) {
    return this.http.post("http://localhost:59421/api/Employee/AddEmployee", employee);
  }

  updateEmployee(id: number, employee: IEmployee) {
    return this.http.post("http://localhost:59421/api/Employee/UpdateEmployee/" + id, employee);
  }
}
