import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TestAllFunctionality';
  myname= "Priyanka Parmar";
  today=Date.now();
  str="Hello ! Welcome to Promact"
  data=[
    {
    name: 'Priyanka',
    age : 23,
    email: 'piyu@gmail.com'
    },
    {
    name: 'Ashiyana',
    age : 23,
    email: 'ashu@gmail.com'
    }
  ]
}
