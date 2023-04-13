import { Injectable } from '@angular/core';
import { Materias } from '../models/materias';
import { environment } from 'src/enviroments/enviroment.development';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class MateriaService {
  baseApiUrl:string = environment.baseApiUrl;
  constructor() { }
  getAllMaterias():Observable<Materias[]>{
    return this.http.get<Materias[]>(this.baseApiUrl+"/api/Materias");
  }
  addMateria(agregarMateriaRequest: Materias):Observable<Materias>{
    agregarMateriaRequest.id='00000000-0000-0000-0000-000000000000';
    return this.http.post<Materias>(this.baseApiUrl+"/api/Materias", agregarMateriaRequest);
  }
  editMateria(id:string, actualizarEstudianteRequest:Materias):Observable<Materias>{
    return this.http.put<Materias>(this.baseApiUrl+"/api/Materias"+ id, actualizarEstudianteRequest );
  }
  deleteMateria(id:string):Observable<Materias>{
    return this.http.delete<Materias>(this.baseApiUrl+"/api/Materias"+ id);
  }
  getMateria(id:string):Observable<Materias>{
    return this.http.get<Materias>(this.baseApiUrl+"/api/Materias"+id);
  } 
}
