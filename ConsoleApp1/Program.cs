
using BrindeVehicleV2;
using BrindeVehicleV2.Elements.Engine;
using BrindeVehicleV2.Elements.Vehiculos;

Vehicle carPetrol = new Car(new PetrolEngine());
carPetrol.Drive();

Vehicle busElectric = new Bus(new ElectricEngine());
busElectric.Drive();