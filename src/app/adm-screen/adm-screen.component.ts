import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatTabsModule} from '@angular/material/tabs';

@Component({
  selector: 'app-adm-screen',
  standalone: true,
  imports: [CommonModule, MatTabsModule],
  templateUrl: './adm-screen.component.html',
  styleUrl: './adm-screen.component.css'
})
export class AdmScreenComponent {

}
