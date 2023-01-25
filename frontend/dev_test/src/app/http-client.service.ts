import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpClientService {

  constructor(private http: HttpClient) { }
  baseUrl = "https://localhost:7124/api/";
  getData(url: string) {
    return this.http.get(this.baseUrl + url);
  }

  postData(url: string, data: any) {
    return this.http.post(this.baseUrl + url, data);
  }
}
