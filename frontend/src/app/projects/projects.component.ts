import { Component, OnInit } from '@angular/core';
import { ProjectService } from '../services/project.service';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.less'
})
export class ProjectsComponent implements OnInit {

  projects: any[] = [];

  constructor(private projectService: ProjectService) { }

  ngOnInit(): void {
    this.projectService.getProjects().subscribe(data => {
      this.projects = data;
    });
  }
}
