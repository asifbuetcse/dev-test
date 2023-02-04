import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpClientService {
  headers = new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': `Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhQGEuY29tIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiYWRtaW4iLCJleHAiOjE2NzUzOTU3MDIsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6Mjg3NDcvIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdDo0MjAwLyJ9.8Xqgd2BmCAmcQ7Ve_HUpGRc8JeVxCwsGNFbAHlq27zk`
  });
  constructor(private http: HttpClient) { }
  baseUrl = "https://localhost:7124/api/";
  getData(url: string) {
    return this.http.get(this.baseUrl + url);
    //return this.http.get(this.baseUrl + url, { headers: this.headers });
  }
  postData(url: string, data: any) {
    return this.http.post(this.baseUrl + url, data);
    //return this.http.post(this.baseUrl + url, data, { headers: this.headers });
  }
}
