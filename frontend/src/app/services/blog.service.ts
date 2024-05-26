import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment'; // Import the environment

@Injectable({
  providedIn: 'root'
})
export class BlogService {

  private apiUrl = `${environment.apiUrl}/api/blog`; // Use environment variable

  constructor(private http: HttpClient) { }

  getBlogPosts(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
