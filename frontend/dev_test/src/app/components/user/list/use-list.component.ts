import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpClientService } from 'src/app/http-client.service';
import { UserModel } from '../../../../models/user';

@Component({
  selector: 'app-use-list',
  templateUrl: './use-list.component.html',
  styleUrls: ['./use-list.component.scss']
})
export class UseListComponent implements OnInit {
  userList: UserModel[] = [];
  _client: HttpClientService;
  constructor(client: HttpClientService) {
    this._client = client;
  }

  ngOnInit(): void {
    this._client.getData("user").subscribe((res) => {
      console.log(res);
      this.userList = res as UserModel[];
    });
  }
}
