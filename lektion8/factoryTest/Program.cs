using factoryTest;

CarFactory carFactory = new CarFactory();
Car volvo = carFactory.GetCar("volvo");
volvo.Drive();