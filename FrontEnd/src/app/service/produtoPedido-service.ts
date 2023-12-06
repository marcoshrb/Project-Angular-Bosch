import { Injectable } from "@angular/core";
import { ApiClientService } from '../api-client.service';

import { ProdutoPedidoData } from '../data/produtopedido-data';
import { Observable, map } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class ProdutoPedidoService {
    constructor(private http: ApiClientService) { }

    register(data: ProdutoPedidoData) {
        this.http.post('produtoPedido/create', data)
            .subscribe(response => console.log(response))
    }

    getProdutos(): Observable<any[]> {
        return this.http.get('produtoPedido/getAll').pipe(
            map((response: any) => {
                return response;
            })
        );
    }

}
