import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  users:any;

  constructor(private accountService:AccountService, private router: Router)
  {

  }
  ngOnInit(): void {
   // this.getUsers();
    this.setCurrentUser();
    localStorage.removeItem('user');
    this.router.navigateByUrl("/");
    
}

setCurrentUser()
{
  const user:User=JSON.parse(localStorage.getItem('user')|| '{}');
  this.accountService.setCurrentUser(user);
}


// getUsers()
// {
//   this.http.get('http://localhost:59831/api/users').subscribe(Response=>{
//       this.users=Response;
//     },error=>{
//       console.log(error);
//     }
    
//     );
//   }
}


