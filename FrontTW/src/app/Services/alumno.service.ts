import { Injectable } from '@angular/core';
import { environment } from 'src/enviroments/enviroment.development';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Alumnos } from '../models/alumnos';

@Injectable({
  providedIn: 'root'
})

export class AlumnoService {
baseApiUrl:string = environment.baseApiUrl;
  constructor(private http:HttpClient) { 
  }
  getAllAlumnos():Observable<Alumnos[]>{
    return this.http.get<Alumnos[]>(this.baseApiUrl+"/api/Alumnos");
  }
  addAlumno(agregarEstudianteRequest: Alumnos):Observable<Alumnos>{
    agregarEstudianteRequest.id='00000000-0000-0000-0000-000000000000';
    return this.http.post<Alumnos>(this.baseApiUrl+"/api/Alumnos", agregarEstudianteRequest);
  }
  editAlumno(id:string, actualizarEstudianteRequest:Alumnos):Observable<Alumnos>{
    return this.http.put<Alumnos>(this.baseApiUrl+"/api/Alumnos"+ id, actualizarEstudianteRequest );
  }
  deleteAlumno(id:string):Observable<Alumnos>{
    return this.http.delete<Alumnos>(this.baseApiUrl+"/api/Alumnos"+ id);
  }
  getAlumno(id:string):Observable<Alumnos>{
    return this.http.get<Alumnos>(this.baseApiUrl+"/api/Alumnos"+id);
  } 
}
