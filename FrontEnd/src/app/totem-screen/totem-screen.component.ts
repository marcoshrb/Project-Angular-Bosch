import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule } from '@angular/forms';

import { Router } from '@angular/router';
import { ProdutoService } from '../service/produto-service';
import { PedidoService } from '../service/pedido-service';
import { ProdutoPedidoService } from '../service/produtoPedido-service';

@Component({
  selector: 'app-totem-screen',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatIconModule, FormsModule],
  templateUrl: './totem-screen.component.html',
  styleUrl: './totem-screen.component.css'
})
export class TotemScreenComponent implements OnInit {

  constructor(
    private product: ProdutoService, 
    private router: Router,
    private pedido: PedidoService,
    private produtoPedido : ProdutoPedidoService
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

      this.criarPedido() ;
  }

  idItem : number = 0
  name: string = "kk"
  total: number = 0
  entregue: boolean = false

  criarPedido() {
    this.pedido.register({
      name: this.name,
      total: this.total,
      entregue: this.entregue
    })
    console.log("Pedido cadastrado!")
  }

  produtoId: number = 0
  pedidoId: number = 0

  criaProdutoPedido() {
    this.produtoPedido.register({
      produtoId : this.produtoId,
      pedidoId : this.pedidoId
    })
    alert("ProdutoPedido cadastrado!")
  }

  bosta( valor : number ) {
    console.log(valor)

    this.produtoId = valor;


  }
}
