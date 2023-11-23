import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule} from '@angular/material/button';

@Component({
  selector: 'app-pedidos-screen',
  standalone: true,
  imports: [CommonModule, MatButtonModule],
  templateUrl: './pedidos-screen.component.html',
  styleUrl: './pedidos-screen.component.css'
})
export class PedidosScreenComponent {

}
