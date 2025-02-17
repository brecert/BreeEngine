using System.ComponentModel;
using System.Reflection;
using Elements.Core;
using FrooxEngine;
using System;

[assembly: AssemblyDescription("BreeEngine, An extension of FrooxEngine")]
[assembly: DataModelAssembly(DataModelAssemblyType.Core)]
[assembly: ExternalDataModelType(typeof(ValueTuple<,>))]
[assembly: ExternalDataModelType(typeof(ValueTuple<,,>))]
[assembly: ExternalDataModelType(typeof(ValueTuple<,,,>))]
[assembly: ExternalDataModelType(typeof(ValueTuple<,,,,>))]
[assembly: ExternalDataModelType(typeof(ValueTuple<,,,,,>))]
[assembly: ExternalDataModelType(typeof(ValueTuple<,,,,,,>))]
[assembly: ExternalDataModelType(typeof(ValueTuple<,,,,,,,>))]
