import { Component, OnInit } from '@angular/core';
import { BlogService } from '../services/blog.service';

@Component({
  selector: 'app-blog',
  standalone: true,
  imports: [],
  templateUrl: './blog.component.html',
  styleUrl: './blog.component.less'
})
export class BlogComponent implements OnInit {

  blogPosts: any[] = [];

  constructor(private blogService: BlogService) { }

  ngOnInit(): void {
    this.blogService.getBlogPosts().subscribe(data => {
      this.blogPosts = data;
    });
  }

}
