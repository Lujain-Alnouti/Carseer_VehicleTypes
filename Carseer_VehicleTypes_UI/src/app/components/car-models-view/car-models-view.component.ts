import { Component, OnInit } from '@angular/core';
import { CarModelsService } from '../../services/car-models.service';
import { MainInterface } from '../../Models/MainInterface';
import { CarMakes_Details } from '../../Models/CarMakes';
import { VehicleTypes_Details } from '../../Models/VehicleTypes';
import { CarModels_Details } from '../../Models/CarModels';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { NgSelectModule } from '@ng-select/ng-select';
declare var $: any;
@Component({
  selector: 'app-car-models-view',
  standalone: true,
  imports: [FormsModule,CommonModule,NgSelectModule],
  templateUrl: './car-models-view.component.html',
  styleUrl: './car-models-view.component.css'
})
export class CarModelsViewComponent implements OnInit {

  AllMakes!:MainInterface<CarMakes_Details>
  VehicleTypes!:MainInterface<VehicleTypes_Details>
  CarModels!:MainInterface<CarModels_Details>
  Years:number[]=[]
  selectedMake:number=0
  selectedYear:number=0
constructor (private CarModelsSer:CarModelsService){}

  ngOnInit(): void {
    this.loadMakes()

    for(let i=1700;i<=2025;i++){
      this.Years.push(i)
    }

  }
//   ngAfterViewInit() {
    
//   $('#makeSelect').select2({
//     placeholder: "Choose",
//     allowClear: true
//   });
//   $('#yearSelect').select2({
//     placeholder: "Choose",
//     allowClear: true
//   });

//   $('#makeSelect').on('change', (e:any) => {
//     this.selectedMake = Number($(e.target).val());
//   });

//   $('#yearSelect').on('change', (e:any) => {
//     this.selectedYear = Number($(e.target).val());
//   });

// }

  loadMakes() {
    this.CarModelsSer.GetMakes().subscribe((res:MainInterface<CarMakes_Details>)=>{
      this.AllMakes=res

    })
  }

CarModels_Search() {

  if (this.selectedMake != 0) {

    this.CarModelsSer.GetVehicles_ByMakeId(this.selectedMake)
    .subscribe((res: MainInterface<VehicleTypes_Details>) => {
      this.VehicleTypes = res;
      console.log(this.VehicleTypes?.results);
    });

    if (this.selectedYear != 0) {

      this.CarModelsSer.GetAllModels_ByMakeId(this.selectedMake, this.selectedYear)
      .subscribe((res: MainInterface<CarModels_Details>) => {
        this.CarModels = res;
        debugger
        console.log(this.CarModels?.results);
      });

    }

  }

}

}
