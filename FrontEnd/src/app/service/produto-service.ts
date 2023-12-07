import { Injectable } from "@angular/core";
import { ApiClientService } from '../api-client.service';

import { ProdutoData } from '../data/produto-data';
import { Observable, map } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class ProdutoService {
    constructor(private http: ApiClientService) { }

    register(data: ProdutoData) {
        this.http.post('produto/create', data)
            .subscribe(response => console.log(response))
    }

    getProdutos(): Observable<any[]> {
        return this.http.get('produto/getAll').pipe(
            map((response: any) => {
                return response;
            })
        );
    }

    // editarProdutos(data: ProdutoData, id : number){

    //     const requestData = { ...data, id: id };

    //     return this.http.put('produto/update', requestData)
    //     .subscribe()
    // } 

}

