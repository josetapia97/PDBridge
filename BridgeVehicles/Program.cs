
/*
 Use case
1. Testa / electric
2. Bus / Petrol
3. Motorcycle / petrol
4. Motorcycle / electric
 */

using BridgeVehicles;
using BridgeVehicles.Elements.Motors;
using BridgeVehicles.Elements.Vehicles;

IMotor melec = new ElectricMotor();
Vehicle testla =  new Testla(melec);
testla.runVehicle("A45 Tesla");

IMotor mpetrol = new PetrolMotor();
Vehicle bus = new Bus(mpetrol);
bus.runVehicle("Micro Pencahue");

Vehicle motitopet = new Motorcycle(mpetrol);
motitopet.runVehicle("Harley Davidson Z75");

Vehicle motitoel = new Motorcycle(melec);
motitoel.runVehicle("Honda Electric J57");
