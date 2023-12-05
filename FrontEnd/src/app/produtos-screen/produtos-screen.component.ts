import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormsModule } from '@angular/forms';

import { Router } from '@angular/router';
import { ProdutoService } from '../service/produto-service';

@Component({
  selector: 'app-produtos-screen',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './produtos-screen.component.html',
  styleUrl: './produtos-screen.component.css'
})
export class ProdutosScreenComponent implements OnInit{

  constructor(
    private product: ProdutoService, 
    private router: Router
    ) 
    { }

  list: any = [];

  name: string = ""
  preco: number = 0
  descricao: string = ""
  promocao: boolean = false
  precoPromocao: number = 0
  cupom: string = "daf"
  descricaoPromocao: string = "ds"

  create() {
    this.product.register({
      name: this.name,
      preco: this.preco,
      descricao: this.descricao,
      promocao: this.promocao,
      precoPromocao: this.precoPromocao,
      cupom : this.cupom,
      descricaoPromocao : this.descricaoPromocao
    })
    console.log("foiii");
    alert("Produto cadastrado!")
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
