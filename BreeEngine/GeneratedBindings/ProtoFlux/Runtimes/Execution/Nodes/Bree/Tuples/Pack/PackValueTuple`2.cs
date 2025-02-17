// <auto-generated/>
/* *******************************
Generated for type: ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple`2
Generated on: 17/02/2025 17:37:10
Source assembly: BreeEngine, Version=2025.2.17.1055, Culture=neutral, PublicKeyToken=null
******************************* */

using System;
using ProtoFlux.Core;
using Elements.Core;
using FrooxEngine;
using FrooxEngine.ProtoFlux;
using ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack
{
    
    [GenericTypes(GenericTypesAttribute.Group.EnginePrimitivesAndEnums)]
    [Grouping("Core.Operators.PackTuple2")]
    [Category("ProtoFlux/Runtimes/Execution/Nodes/Tuples/Pack")]
    public  partial class PackValueTuple<T0, T1> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext, global::System.ValueTuple<T0, T1>>
        
         where T0 : unmanaged where T1 : unmanaged
    {
        public override Type NodeType => typeof(global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1>);

        public static bool IsValidGenericType => global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1>.IsValidGenericType;

        
public global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1> TypedNodeInstance { get; private set;}
public override INode NodeInstance => TypedNodeInstance;

public override N Instantiate<N>()
{
                if(TypedNodeInstance != null)
                    throw new InvalidOperationException("Node has already been instantiated");

                var node = new global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1>();

                TypedNodeInstance = node;

                OnInstantiated();

                return node as N;
}

partial void OnInstantiated();

protected override void AssociateInstanceInternal(INode node)
{
    if(node is global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1> typedNode)
    {
        TypedNodeInstance = typedNode;

        OnInstantiated();
    }
    else
        throw new ArgumentException("Node instance is not of type " + typeof(global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1>));
}

public override void ClearInstance() => TypedNodeInstance = null;


        
        
        

        public override int NodeInputCount => base.NodeInputCount + 2;
        

        
        

        
        

        
        

        

        
        

             protected override ISyncRef GetInputInternal(ref int index)
        {
            var @base = base.GetInputInternal(ref index);

            if(@base != null)
                return @base;

            switch(index)
            {
                case 0: return Arg0;
case 1: return Arg1;

                default:
                    index -= 2;
                    return null;
            };
        }

        
        
        

        

        
        
        
        

        
        

        public override string NodeName => "Pack Tuple";


		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T0>> Arg0;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T1>> Arg1;

    }
}
