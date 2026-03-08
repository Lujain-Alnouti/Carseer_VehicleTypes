import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MainInterface } from '../Models/MainInterface';
import { CarMakes_Details } from '../Models/CarMakes';
import { VehicleTypes_Details } from '../Models/VehicleTypes';
import { CarModels_Details } from '../Models/CarModels';

@Injectable({
  providedIn: 'root'
})
export class CarModelsService {
baseUrl = "http://localhost:5118/api/Vehicles";
  constructor(private http:HttpClient) { }

//get all Company Name 
GetMakes(){
  //
   return this.http.get<MainInterface<CarMakes_Details>>(`${this.baseUrl}/Makes`);
}

//get all Vehicle Types according selected company (car make)
GetVehicles_ByMakeId(makeId:number){
  return this.http.get<MainInterface<VehicleTypes_Details>>(`${this.baseUrl}/Vehicles?MakeId=${makeId}`);
}

// Get all car models selected by company (car make) & year of manufacture
GetAllModels_ByMakeId(makeId:number,year:number){
  return this.http.get<MainInterface<CarModels_Details>>(`${this.baseUrl}/CarModels?Year=${year}&MakeId=${makeId}`)
}
}
