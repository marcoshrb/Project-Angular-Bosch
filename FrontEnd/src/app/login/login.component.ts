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

  hidePassword = true;
  username = "";
  password = "";

  logar()
  {
    if(this.username == "" || this.password == ""){
      alert('Preencha todos os campos!')
      return;
    }

    this.client.login({
      name: this.username,
      password: this.password
    }, (result: any) => {
      if (result == null)
      {
        alert('Senha ou usuário incorreto!')
        
      }
      else
      {
        sessionStorage.setItem('jwt', JSON.stringify(result))
        if(result.adm){
          console.log("aaaaaaaaaaaaaaaaaaa")
          this.router.navigate(['produtos'])
        }
        else{
          console.log("ddddddddddddddddddddddd")
          this.router.navigate(['cliente'])
        }
      }
    })
  }

  cadastrar(){
    this.router.navigate(['cadastro'])
  }

}
