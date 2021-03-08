import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  constructor(private http:HttpClient) { }

Url : string = "http://localhost:58506/api/Productos";

addproductor(producto:any){

  const urlapi = this.Url;
  this.http.post(urlapi,producto).subscribe((data:any)=>data);
}


Findall(){
  const urlapi = this.Url;
  return this.http.get(urlapi);
}



}
