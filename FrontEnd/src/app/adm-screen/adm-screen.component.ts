import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatTabsModule} from '@angular/material/tabs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adm-screen',
  standalone: true,
  imports: [CommonModule, MatTabsModule],
  templateUrl: './adm-screen.component.html',
  styleUrl: './adm-screen.component.css'
})
export class AdmScreenComponent {
  
  constructor( private router: Router) { }

  produtos(){
    this.router.navigate(['produtos'])
  }
  pedidos(){
    this.router.navigate(['pedidos'])
  }
  totem(){
    this.router.navigate(['totem'])
  }
}
