import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ProductoService } from '../../service/producto.service';
@Component({
  selector: 'app-crear',
  templateUrl: './crear.component.html',
  styleUrls: ['./crear.component.css']
})
export class CrearComponent implements OnInit {


  constructor(private productoservice:ProductoService) { }

agregar(formulario:NgForm) {

this.productoservice.addproductor({
  nombre:formulario.value.nombre,
  precio:formulario.value.precio,
  stock:formulario.value.stock
});

 }



  ngOnInit(): void {
  }

}
