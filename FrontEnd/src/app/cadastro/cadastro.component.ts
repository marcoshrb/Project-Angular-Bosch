import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientService } from '../client-service';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.css'
})

export class CadastroComponent {
  constructor(private client: ClientService) { }

  name: string = ""
  password: string = ""
  repeatPassword: string = ""

  create()
  {
    this.client.register({
      login: this.name,
      password: this.password
    })

  }
}
