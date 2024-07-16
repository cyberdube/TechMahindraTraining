import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Post } from './post.model'; // Adjusted import path

@Injectable({
  providedIn: 'root'
}) 
export class PostService {
  private apiUrl: string = 'http://localhost:3000';

  constructor(private httpClient: HttpClient) { }

  createPost(post: Post): Observable<Post> {
    const url = `${this.apiUrl}/createpost`;
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient.post<Post>(url, post, { headers });
  }

  getAllPosts(): Observable<Post[]> {
    const url = `${this.apiUrl}/allposts`;
    return this.httpClient.get<Post[]>(url);
  }

  getPostById(id: number): Observable<Post> {
    const url = `${this.apiUrl}/posts/${id}`;
    return this.httpClient.get<Post>(url);
  }

  deletePostById(id: number): Observable<any> {
    const url = `${this.apiUrl}/deletepost/${id}`;
    return this.httpClient.delete(url);
  }
}
