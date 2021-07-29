import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit{
  public usuario;// = new Usuario();
  public returnUrl: string;
    
  


 public usuarioAutenticado: boolean;

  constructor(private router: Router, private ActivatedRouter: ActivatedRoute) { 
  }
    ngOnInit(): void {
      this.returnUrl = this.ActivatedRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }

  entrar() {
    if (this.usuario.email == "joabesk@gmail.com" && this.usuario.senha == "ti!gers38") {

      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);

     this.usuarioAutenticado = true;
    }
   
  }


}

