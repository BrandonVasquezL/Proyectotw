/*import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AddAlumnoComponent } from './Componentes/Alumnos/add-alumno/add-alumno.component';
import { EditAlumnoComponent } from './Componentes/Alumnos/edit-alumno/edit-alumno.component';
import { AlumnoListComponent } from './Componentes/Alumnos/alumno-list/alumno-list.component';

@NgModule({
  declarations: [
    AppComponent,
    AddAlumnoComponent,
    EditAlumnoComponent,
    AlumnoListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }*/

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

import { HttpClient} from '@angular/common/http';
import { AddAlumnoComponent } from './Componentes/Alumnos/add-alumno/add-alumno.component';
import { EditAlumnoComponent } from './Componentes/Alumnos/edit-alumno/edit-alumno.component';
import { AlumnoListComponent } from './Componentes/Alumnos/alumno-list/alumno-list.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AddAlumnoComponent,
    EditAlumnoComponent,
    AlumnoListComponent
 
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
