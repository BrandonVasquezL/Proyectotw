import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Materias} from 'src/app/models/materias';
import { MateriaService } from 'src/app/services/materia.service';

@Component({
  selector: 'app-add-materia',
  templateUrl: './materia.component.html',
  styleUrls: ['./materia.component.css']
})
export class MateriaComponent implements OnInit{
  agregarMateriaRequest:Materias = {
    id:"",
    nrc: 0,
    maestro:'',
    cant_alumnos: 0
  };

  constructor(private materiasServicio: MateriaService, private router: Router){

  }

  ngOnInit(): void {
    
  }

  agregarAlumno(){
    this.materiasServicio.addMateria(this.agregarMateriaRequest)
    .subscribe({
      next:(materia)=>{
        this.router.navigate(['materias']);
      }
    });
  }
}
