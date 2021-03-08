import { Component, OnInit } from '@angular/core';
import { ProductoService } from '../../service/producto.service';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrls: ['./listar.component.css']
})
export class ListarComponent implements OnInit {

  listproducto:any;

  constructor(private productoservice:ProductoService) { }





  ngOnInit(): void {

    this.productoservice.Findall().subscribe(prod=>this.listproducto=prod)

  }

}
