import { Component } from "@angular/core";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  
  entrar() {
    alert('entrar no sistema');
  }

  on_keypress() {
    alert('Foi digitado no campo de email');
  }
}

