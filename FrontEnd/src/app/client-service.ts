import { Injectable } from '@angular/core';
import { ClientData } from './client-data';
import { ApiClientService } from './api-client.service';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  constructor(private http: ApiClientService) { }

  register(data: ClientData)
  {
    this.http.post('usuario/register', data)
      .subscribe(response => console.log(response))
  }

  login(data: ClientData, callback: any)
  {
    this.http.post('usuario/login', data)
      .subscribe(
        response => {
          callback(response)
        },
        error => { 
          callback(null)
        })
  }
}
