import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ClientService } from '../service/client-service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.css'
})

export class CadastroComponent {
  constructor(
    private router: Router,
    private client: ClientService) { }

  name: string = ""
  password: string = ""
  repeatPassword: string = ""

  create() {
    if (this.name == "" || this.password == ""
      || this.repeatPassword == ""){
        alert('Preencha todos os campos!');
        return;
      }

    if (this.password != this.repeatPassword) {
      alert('As senhas não são iguais!');
      return;
    }

    alert('Cadastro feito com sucesso!');
    setTimeout(() => this.router.navigate(['']))
    this.client.register({
      name: this.name,
      password: this.password
    })

  }

  ScreenLogin(){
    this.router.navigate([''])
  }
}
