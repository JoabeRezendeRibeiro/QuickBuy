import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario = new Usuario();

    public usuarioAutenticado: boolean;

  constructor() {
    this.usuario = new Usuario();
  }


 

  entrar() {
    if (this.usuario.email == "joabesk@gmail.com" && this.usuario.senha == "ti!gers38") {

      this.usuarioAutenticado = true;
    }
   
  }


}

