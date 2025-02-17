using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using static System.Linq.Enumerable;


namespace SourceGenerators;

[Generator]
public class UnackValueTupleGenerator : ISourceGenerator
{
  public void Initialize(GeneratorInitializationContext context)
  {
  }

  public void Execute(GeneratorExecutionContext context)
  {
    foreach (var i in Range(2, 6))
    {
      var tupleSource = GenerateTuple(i);
      Console.WriteLine(tupleSource);
      context.AddSource($"UnpackValueTuple{i}.g.cs", tupleSource);
    }
  }

  private string GenerateTuple(int size)
  {
    var types = string.Join(", ", Range(0, size).Select(n => $"T{n}"));

    return $$"""
    // generated

    using FrooxEngine.ProtoFlux;
    using ProtoFlux.Core;
    using FrooxEngine;

    namespace ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack;

    [NodeCategory("Tuples/Unpack")]
    [NodeName("Unpack Tuple")]
    [GenericTypes(GenericTypesAttribute.Group.EnginePrimitives)]
    public class UnpackValueTuple<{{types}}> : VoidNode<FrooxEngineContext> {{string.Join(" ", Range(0, size).Select(n => $"where T{n} : unmanaged"))}}
    {
      public ValueInput<ValueTuple<{{types}}>> Tuple;

      {{string.Join("\n", Range(0, size).Select(n => $"public readonly ValueOutput<T{n}> Value{n};"))}}

      protected override void ComputeOutputs(FrooxEngineContext context)
      {
        var ({{string.Join(", ", Range(0, size).Select(n => $"value{n}"))}}) = Tuple.Evaluate(context);
        {{string.Join("\n", Range(0, size).Select(n => $"Value{n}.Write(value{n}, context);"))}}
      }

      public UnpackValueTuple()
      {
        {{string.Join("\n", Range(0, size).Select(n => $"Value{n} = new(this);"))}}
      }
    }
    """;
  }
}
