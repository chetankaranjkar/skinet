import { Component, OnInit } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { BasketService } from 'src/app/basket/basket.service';
import { IBasket, IBasketTotals } from "../../models/basket";


@Component({
  selector: 'app-order-totals',
  templateUrl: './order-totals.component.html',
  styleUrls: ['./order-totals.component.scss']
})

  
export class OrderTotalsComponent implements OnInit {

  constructor(private basketService:BasketService) { }

  basketTotals$: Observable<IBasketTotals>;

  ngOnInit(): void {
    this.basketTotals$=this.basketService.basketTotal$;
  }

}
