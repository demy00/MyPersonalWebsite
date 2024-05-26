import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProjectsComponent } from './projects/projects.component';
import { BlogComponent } from './blog/blog.component';
import { AboutComponent } from './about/about.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'projects', component: ProjectsComponent },
  { path: 'blog', component: BlogComponent },
  { path: 'about', component: AboutComponent }
];