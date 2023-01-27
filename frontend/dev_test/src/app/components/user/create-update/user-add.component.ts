import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { HttpClientService } from 'src/app/http-client.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html',
  styleUrls: ['./user-add.component.scss']
})
export class UserAddComponent implements OnInit {
  userForm = new FormGroup({
    name: new FormControl(),
    email: new FormControl(),
    mobile: new FormControl(),
    isActive: new FormControl(),
    role: new FormControl()
  });
  _client: HttpClientService;
  constructor(client: HttpClientService) {
    this._client = client;
  }

  ngOnInit(): void {
  }

  cancel() {
    this.userForm = new FormGroup({
      name: new FormControl(),
      email: new FormControl(),
      mobile: new FormControl(),
      isActive: new FormControl(),
      role: new FormControl()
    });
  }

  save() {
    this._client.postData("user", this.userForm.value).subscribe((res) => {
      console.log(res);
    });
  }


}
