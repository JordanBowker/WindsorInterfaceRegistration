# WindsorInterfaceRegistration

Created this project to investigate how to register multiple interfaces to the same factory method and how DI works with multiple interface inheritance.

There exists an interface IGlobalSettings, which inherits two LocalSettings interfaces: ILocalSettingsA and ILocalSettingsB.
I have implemented the IGlobalSettings on GlobalSettings, and have a factor method that populates the GlobalSettings.

There are also three worker classes that use DI and simply get a property. 
For example, ILocalSettingsA is injected into WorkerA which has a method to get the property 'SettingsA' from the injected settings.

I have simple Tests which show how to register the interfaces and tests the factory works.

