import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AccountService } from './account/account.service';
import { BasketService } from './basket/basket.service';
import { IPagination } from './shared/models/pagination';
import { IProduct } from './shared/models/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'Skinet';

  constructor(private basketService: BasketService,private accountService:AccountService) { }

  ngOnInit(): void 
  {
    console.log('onIt');
    this.loadBasket();
    this.loadcurrentUser();
  }

  loadcurrentUser(){
    console.log(localStorage.getItem('token'));
    const token = localStorage.getItem('token');
   
      this.accountService.loadCurrentUser(token).subscribe(()=>{
        console.log('loaded user');
      },error=>{
        console.log(error);
       
      });
    
  }

  loadBasket(){
    const basketid = localStorage.getItem('basket_id');
    if (basketid) {
      this.basketService.getBasket(basketid).subscribe(()=>{
        console.log('initialize basket')
      },error=>{
        console.log(error);
       
      });
    }
  }
}
