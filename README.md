# JsonConfig
A .NET Solution for maintaining your configs as structured JSON file using Autofac.

Appsetting section in Web.Config/App.Config can be massive and diffcult to organize as the application grows. It is also very usual to have multiple key & value added only for single purpose. Besides, consider what if you want to store an array. 

Using JSON as a format to organize such kind of structured setting values may help this issuse since you will have a clear view of which setting values are accompanied with. 

## Requirement plugins

- Newtonsoft.Json

- Autofac

## How to use
+ Create a json file named "Config.json", this is the new place to store your setting values in JSON format.

+ Create a class that implements IAppPathProvider, which should have a property to tell the directory you store for the json config file.

+ Create a class for your structured config, and name it with suffix of "JsonConfig". And the prefix must be the same as the propery name in your Config.json.

 For example, your Config.json looks something like this:

```
{
  "MyWeb": {
    "Host": "127.0.0.1",
    "Port": "8080"    
  },
  "MyAccount": {    
    "Name": "JohnWick",
    "Code": "BoogeyMan"
  },
}
```

Then you should create two classes like this:
```
    public class MyWebJsonConfig
    {
        public string Host { get; set; }
        public string Port { get; set; }
    }

    public class MyAccountJsonConfig
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
```

+ Create class to inherit Autofac.Module, override its Load(ContainerBuilder builder) method. Inside the methods, get your JsonConfig class as a type list, then loop it to register via IJsonConfigProvider.LoadSection(type).

+ Create a class with a static method which register everything that uses autofac. Inside the method register implemented class for IAppPathProvider and IJsonConfigProvider. Then register your autofac module class mentioned above. 

## Note

+ For windows service or console application, let the static method return the result of ContainerBuilder.Build() to get the container to resolve classes.

+ For web application, just return void. And use DependencyResolver to resolve classes later on.

## Get the config

Use the container or DependencyResolver to resolve your JsonConfig class, and that's it.



