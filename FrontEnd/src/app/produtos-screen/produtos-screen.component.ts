import { Component } from '@angular/core';
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
export class ProdutosScreenComponent {

  constructor(
    private product: ProdutoService, 
    private router: Router
    ) 
    { }


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
}
