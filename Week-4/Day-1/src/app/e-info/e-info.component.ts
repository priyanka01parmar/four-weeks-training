import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-e-info',
  templateUrl: './e-info.component.html',
  styleUrls: ['./e-info.component.css'],
  providers: [DataService]
})
export class EInfoComponent implements OnInit {
    infoReceived1:string[]=[];
    infoReceived2:string[]=[];
    infoReceived3:string[]=[];

    getInfor1(){
      this.infoReceived1= this.dservice.getinfo1()
    }
    getInfor2(){
      this.infoReceived2= this.dservice.getinfo2()
    }
    getInfor3(){
      this.infoReceived3= this.dservice.getinfo3()
    }

  constructor(private dservice: DataService){}
  ngOnInit(): void {
  } 
  updateinfo(frm: any){
    this.dservice.addinfo(frm.value.location)
  }
}
