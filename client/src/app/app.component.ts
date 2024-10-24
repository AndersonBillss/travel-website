import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HelloWorldService } from './services/hello-world.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit{
  constructor(
    private _helloWorldService: HelloWorldService
  ){ }

  ngOnInit(): void {
    this._helloWorldService.getHelloWorld().subscribe((data: any) => {
      console.log(data)
    })
  }
}
