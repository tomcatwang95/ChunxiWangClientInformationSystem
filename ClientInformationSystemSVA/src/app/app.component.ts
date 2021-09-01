import { Component } from '@angular/core';
import { AuthService } from './Core/Service/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ClientInformationSystemSVA';
  constructor (private authService:AuthService){
     
  }
  ngOnInit(): void {
    this.authService.populateEmployeeInfo();
    
  }
}
