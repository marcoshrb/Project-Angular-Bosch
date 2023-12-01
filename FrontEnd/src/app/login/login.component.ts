import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientService } from '../client-service';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  constructor (
    private router: Router,
    private client: ClientService
    ) 
    { }

  username = "";
  password = "";

  logar()
  {

    if(this.username == "" || this.password == "")
      return;

    this.client.login({
      name: this.username,
      password: this.password
    }, (result: any) => {
      if (result == null)
      {
        alert('Senha ou usuário incorreto!')
        return;
      }
      else
      {
        sessionStorage.setItem('jwt', JSON.stringify({'value' : result.jwt}))
        this.router.navigate(['adm']);
      }
    })
  }

  cadastrar(){
    this.router.navigate(['cadastro'])
  }

}
