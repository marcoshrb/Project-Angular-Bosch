import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';

import { Router } from '@angular/router';
import { ProdutoService } from '../service/produto-service';

@Component({
  selector: 'app-totem-screen',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatIconModule],
  templateUrl: './totem-screen.component.html',
  styleUrl: './totem-screen.component.css'
})
export class TotemScreenComponent implements OnInit {

  constructor(
    private product: ProdutoService, 
    private router: Router
    ) 
    { }

  showComponent = true;
  maisDetalhes = false;

  list: any = [];

  toggleComponent() {
    this.showComponent = !this.showComponent;
  }
  togglemaisDetalhes() {
    this.maisDetalhes = !this.maisDetalhes;
  }

  ngOnInit() {
    this.product.getProdutos().subscribe(
      (data: any) => {
        this.list = data;
        console.log("produtos:", this.list);
      },
      (error: any) => {
        console.error('Erro ao obter produtos:', error);
      }
    );
  }
}
