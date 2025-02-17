// <auto-generated/>
/* *******************************
Generated for type: ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple`7
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
    [Grouping("Core.Operators.PackTuple7")]
    [Category("ProtoFlux/Runtimes/Execution/Nodes/Tuples/Pack")]
    public  partial class PackValueTuple<T0, T1, T2, T3, T4, T5, T6> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext, global::System.ValueTuple<T0, T1, T2, T3, T4, T5, T6>>
        
         where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        public override Type NodeType => typeof(global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1, T2, T3, T4, T5, T6>);

        public static bool IsValidGenericType => global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1, T2, T3, T4, T5, T6>.IsValidGenericType;

        
public global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1, T2, T3, T4, T5, T6> TypedNodeInstance { get; private set;}
public override INode NodeInstance => TypedNodeInstance;

public override N Instantiate<N>()
{
                if(TypedNodeInstance != null)
                    throw new InvalidOperationException("Node has already been instantiated");

                var node = new global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1, T2, T3, T4, T5, T6>();

                TypedNodeInstance = node;

                OnInstantiated();

                return node as N;
}

partial void OnInstantiated();

protected override void AssociateInstanceInternal(INode node)
{
    if(node is global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1, T2, T3, T4, T5, T6> typedNode)
    {
        TypedNodeInstance = typedNode;

        OnInstantiated();
    }
    else
        throw new ArgumentException("Node instance is not of type " + typeof(global::ProtoFlux.Runtimes.Execution.Nodes.Bree.Tuples.Pack.PackValueTuple<T0, T1, T2, T3, T4, T5, T6>));
}

public override void ClearInstance() => TypedNodeInstance = null;


        
        
        

        public override int NodeInputCount => base.NodeInputCount + 7;
        

        
        

        
        

        
        

        

        
        

             protected override ISyncRef GetInputInternal(ref int index)
        {
            var @base = base.GetInputInternal(ref index);

            if(@base != null)
                return @base;

            switch(index)
            {
                case 0: return Arg0;
case 1: return Arg1;
case 2: return Arg2;
case 3: return Arg3;
case 4: return Arg4;
case 5: return Arg5;
case 6: return Arg6;

                default:
                    index -= 7;
                    return null;
            };
        }

        
        
        

        

        
        
        
        

        
        

        public override string NodeName => "Pack Tuple";


		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T0>> Arg0;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T1>> Arg1;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T2>> Arg2;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T3>> Arg3;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T4>> Arg4;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T5>> Arg5;
		public readonly SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<T6>> Arg6;

    }
}
