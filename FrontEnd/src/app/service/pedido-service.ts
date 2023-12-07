import { Injectable } from "@angular/core";
import { ApiClientService } from '../api-client.service';

import { PedidoData } from '../data/pedido-data';
import { Observable, map } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class PedidoService {
    constructor(private http: ApiClientService) { }

    register(data: PedidoData) {
        this.http.post('pedido/create', data)
            .subscribe(response => console.log(response))
    }

    getPedidos(): Observable<any[]> {
        return this.http.get('pedido/getAll').pipe(
            map((response: any) => {
                return response;
            })
        );
    }

}

