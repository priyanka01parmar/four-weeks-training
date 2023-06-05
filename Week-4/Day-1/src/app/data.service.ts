import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  info1:string[]=['piu','e01','piu@gmail.com']
  info2:string[]=['ashu','e02','ashu@gmail.com']
  info3:string[]=['dhoni','e03','dhoni@gmail.com']

  getinfo1():string[]{
    return this.info1
  }
  
  getinfo2():string[]{
    return this.info2
  }
  
  getinfo3():string[]{
    return this.info3
  }
  addinfo(info: any){
    this.info1.push(info)
    this.info2.push(info)
    this.info3.push(info)
    return this.info1
  }
  
  constructor() { }
}
