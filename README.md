# DotNet.EntityAttributeValue.Abstractions

This library provides abstractions for the
[Entity-Attribute-Value model](https://en.wikipedia.org/wiki/Entity%E2%80%93attribute%E2%80%93value_model).

> (_From Wikipedia_) An **entity–attribute–value model** (EAV) is a data model 
> optimized for the space-efficient storage of sparse—or ad-hoc—property or 
> data values, intended for situations where runtime usage patterns are 
> arbitrary, subject to user variation, or otherwise unforeseeable using a 
> fixed design. The use-case targets applications which offer a large or rich 
> system of defined property types, which are in turn appropriate to a wide set
> of entities, but where typically only a small, specific selection of these 
> are instantiated (or persisted) for a given entity. Therefore, this type of
> data model relates to the mathematical notion of a sparse matrix.
>
> EAV is also known as **object–attribute–value model**, **vertical database**
> **model**, and **open schema**.

## About abstraction

Abstraction is a core concept of Object Oriented Programing (OOP). It alows to
hide complexity from the end-user (here a developer) using, among other 
concepts, interfaces and abstract classes.

A real-life example of abstraction is the tap you use to pour water in a glass.

You simply need to bring a glass, turn on the tap to run water and turn it of
when the glass is full.

How water is processed to be cleaned, delivered to the tap or eventually 
discharged from the sink is not important for your task.

The tap installed in the kitchen is an implementation of a *tap* interface that
uses the water delivery system. All you have to know is that when you turn it 
on, water is pouring and when you turn it off, it stops.

If you change the tap in the kitchen, you change the implementation but the way
you use it is still the same : when you turn it on water is pouring and when 
you turn it off it stops. The interface is unchanged, the complexity is still
hidden.

The same goes for OOP, with abstraction we bring interfaces and abstract 
classes to provide a consistent way of implementing some mechanics. If you
change the implementation you do not need to change anything else.

## How to install

Choose the method that suits your needs.

### Package Manager

```sh
Install-Package Kuchulem.DotNet.EntityAttributeValue.Abstractions -Version 1.0.0
```

### .net CLI

```sh
dotnet add package Kuschulem.DotNet.EntityAttributeValue.Abstractions --version 1.0.0
```

### package reference

```xml
<PackageReference Include="Kuschulem.EntityAttributeValue.Abstractions" Version="1.0.0" />
```

## Usage

As this library provide abstraction, you won't use it alone. Either you will
use it with another library implementing it or you will write your own code
implementing the library.

In either way, when manipulating the implementations you will prefere to use
the interfaces or abstract classes from the abstraction library than the 
implemented classes. So when changing implementation you won't have anything 
to change.

Example implementing and using `IEavValueConverterProvider` :

> The `IEavValueConverterProvider` is an abstraction for a service that will
> provide services to convert a raw value (as stored in db) to a typed and 
> usable value in the application.

```csharp
// Implementing the IEavValueConverterProvider
namespace MyApp.EavImplementations
{
    /// <summary>
    /// Implements the IEavValueConverterProvider interface
    /// </summary>
    public class EavValueConverterProvider : IEavValueConverterProvider
    {
        public IEavValueConverterProvider Register<T>(
            EavValueKind valueKind, 
            IEavValueConverter<T> converter
        ) {
            // implentation of the method
        }

        public IEavValueConverterProvider Register<T>(
            IEavAttribute attribute, 
            IEavValueConverter<T> converter
        ) {
            // implentation of the method
        }

        public IEavValueConverter<T> GetConverter<T>(EavValueKind valueKind)
        {
            // implentation of the method
        }

        public IEavValueConverter<T> GetConverter<T>(IEavAttribute attribute)
        {
            // implentation of the method
        }

        public bool TryGetConverter<T>(
            EavValueKind valueKind, 
            out IEavValueConverter<T>? converter
        ) {
            // implentation of the method
        }

        public bool TryGetConverter<T>(IEavAttribute attribute, out IEavValueConverter<T>? converter)
        {
            // implentation of the method
        }
    }
}

// Define a service that uses the provider
namespace MyApp.Services
{
    public class SampleService
    {
        private readonly IEavValueConverterProvider converterProvider;

        /// <summary>
        /// Expects an instance of IEavValueConverterProvider to be 
        /// </summary>
        public SampleService(IEavValueConverterProvider converterProvider)
        {
            this.converterProvider = converterProvider;
        }

        public DateTime GetBestBeforeDate(FoodProduct product)
        {
            // Code to retrieve the product
            IEavValue bestBeforeValue = product.Values.first(
                v => v.Attribute.attributeName === "bestBeforeDate"
            );

            return (DateTime) converterProvider.GetConverter(bestBeforeValue.Attribute)
                .Convert(bestBeforeValue);
        }
    }
}
```

In this example (a little dumb), we never use explicitly the 
`EavValueConverterProvider` class, instead we use the abstraction with the
`IEavValueConverterProvider` interface. The same goes for the `IEavValue`
interface.
