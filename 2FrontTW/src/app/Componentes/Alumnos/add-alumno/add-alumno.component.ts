import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Alumnos } from 'src/app/models/alumnos';
import { AlumnoService } from 'src/app/Services/alumno.service';


@Component({
  selector: 'app-add-alumno',
  templateUrl: './add-alumno.component.html',
  styleUrls: ['./add-alumno.component.css']
})
export class AddAlumnoComponent implements OnInit{

  agregarEstudianteRequest:Alumnos = {
    id:"",
    matricula: '',
    nombre:'',
    apellido:'',
    nrc: 0
  };

  constructor(private alumnosServicio: AlumnoService, private router: Router){

  }

  ngOnInit(): void {
    
  }
  agregarAlumno(){
    this.alumnosServicio.addAlumno(this.agregarEstudianteRequest)
    .subscribe({
      next:(alumno)=>{
        this.router.navigate(['alumnos']);
      }
    });
  }
}
