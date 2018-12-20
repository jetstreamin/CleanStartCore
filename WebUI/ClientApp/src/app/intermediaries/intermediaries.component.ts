import { Component } from '@angular/core';
import { IntermediariesClient, IntermediariesListViewModel } from '../gatesdsp-api';

@Component({
  selector: 'app-intermediaries',
  templateUrl: './intermediaries.component.html'
})
export class IntermediariesComponent {

  vm: IntermediariesListViewModel;

  constructor(client: IntermediariesClient) {
    client.getAll().subscribe(result => {
      this.vm = result;
    }, error => console.error(error));
  }
}
