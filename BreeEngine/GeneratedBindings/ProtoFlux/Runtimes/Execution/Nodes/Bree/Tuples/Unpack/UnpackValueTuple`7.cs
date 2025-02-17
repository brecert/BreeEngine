// <auto-generated/>
/* *******************************
Generated for type: ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple`7
Generated on: 17/02/2025 17:37:10
Source assembly: BreeEngine, Version=2025.2.17.1055, Culture=neutral, PublicKeyToken=null
******************************* */

using System;
using ProtoFlux.Core;
using Elements.Core;
using FrooxEngine;
using FrooxEngine.ProtoFlux;
using ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack
{
    
    [GenericTypes(GenericTypesAttribute.Group.EnginePrimitivesAndEnums)]
    [Grouping("Core.Operators.UnpackTuple7")]
    [Category("ProtoFlux/Runtimes/Execution/Nodes/Tuples/Unpack")]
    public  partial class UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>
        
         where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        public override Type NodeType => typeof(global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6>);

        public static bool IsValidGenericType => global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6>.IsValidGenericType;

        
public global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6> TypedNodeInstance { get; private set;}
public override INode NodeInstance => TypedNodeInstance;

public override N Instantiate<N>()
{
                if(TypedNodeInstance != null)
                    throw new InvalidOperationException("Node has already been instantiated");

                var node = new global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6>();

                TypedNodeInstance = node;

                OnInstantiated();

                return node as N;
}

partial void OnInstantiated();

protected override void AssociateInstanceInternal(INode node)
{
    if(node is global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6> typedNode)
    {
        TypedNodeInstance = typedNode;

        OnInstantiated();
    }
    else
        throw new ArgumentException("Node instance is not of type " + typeof(global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Unpack.UnpackValueTuple<T0, T1, T2, T3, T4, T5, T6>));
}

public override void ClearInstance() => TypedNodeInstance = null;


        
        
        

        public override int NodeInputCount => base.NodeInputCount + 1;
        

        public override int NodeOutputCount => base.NodeOutputCount + 7;
        

        
        

        
        

        

        
        

             protected override ISyncRef GetInputInternal(ref int index)
        {
            var @base = base.GetInputInternal(ref index);

            if(@base != null)
                return @base;

            switch(index)
            {
                case 0: return Tuple;

                default:
                    index -= 1;
                    return null;
            };
        }

             protected override INodeOutput GetOutputInternal(ref int index)
        {
            var @base = base.GetOutputInternal(ref index);

            if(@base != null)
                return @base;

            switch(index)
            {
                case 0: return Value0;
case 1: return Value1;
case 2: return Value2;
case 3: return Value3;
case 4: return Value4;
case 5: return Value5;
case 6: return Value6;

                default:
                    index -= 7;
                    return null;
            };
        }

        
        

        

        
        
        
        

        
        

        public override string NodeName => "Unpack Tuple";


		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.ValueTuple<T0, T1, T2, T3, T4, T5, T6>>> Tuple;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T0> Value0;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T1> Value1;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T2> Value2;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T3> Value3;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T4> Value4;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T5> Value5;
		public readonly global::FrooxEngine.ProtoFlux.NodeValueOutput<T6> Value6;

    }
}
