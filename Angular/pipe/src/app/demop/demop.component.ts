import { Component } from '@angular/core';

@Component({
  selector: 'app-demop',
  templateUrl: './demop.component.html',
  styleUrl: './demop.component.css'
})
export class DemopComponent
 {
    today:number = Date.now();
    text:string = "Shubhank";
    amount:number = 1212;
    percentage: number = 0.59;
}
