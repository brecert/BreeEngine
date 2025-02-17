using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using static System.Linq.Enumerable;


namespace SourceGenerators;

[Generator]
public class PackValueTupleGenerator : ISourceGenerator
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
            context.AddSource($"PackValueTuple{i}.g.cs", tupleSource);
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
        using BreeEngine.TupleExtensions;

        namespace ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack;

        [NodeCategory("Tuples/Pack")]
        [NodeName("Pack Tuple")]
        [NodeOverload("Core.Operators.PackTuple{{size}}")]
        [GenericTypes(GenericTypesAttribute.Group.EnginePrimitives)]
        public class PackValueTuple<{{types}}> : ValueFunctionNode<FrooxEngineContext, ValueTuple<{{types}}>> {{string.Join(" ", Range(0, size).Select(n => $"where T{n} : unmanaged"))}}
        {
            {{string.Join("\n", Range(0, size).Select(n => $"public ValueInput<T{n}> Arg{n};"))}}

            public static bool IsValidGenericType => TupleHelper.IsValidTupleType(typeof(ValueTuple<{{types}}>));

            protected override ValueTuple<{{types}}> Compute(FrooxEngineContext context)
            {
                {{string.Join("\n", Range(0, size).Select(n => $"var arg{n} = Arg{n}.Evaluate(context);"))}}
                return new({{string.Join(", ", Range(0, size).Select(n => $"arg{n}"))}});
            }
        }
        """;
    }
}
