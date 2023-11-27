import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';

@Component({
  selector: 'app-totem-screen',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatIconModule],
  templateUrl: './totem-screen.component.html',
  styleUrl: './totem-screen.component.css'
})
export class TotemScreenComponent {

  showComponent = true;
  maisDetalhes = false;

  toggleComponent() {
    this.showComponent = !this.showComponent;
  }
  togglemaisDetalhes() {
    this.maisDetalhes = !this.maisDetalhes;
  }
}
