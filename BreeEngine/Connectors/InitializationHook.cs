using System.ComponentModel;
using FrooxEngine;

namespace BreeEngine.Connectors;

/// <summary>
/// Acts as a fake connector, letting us run code at FrooxEngine's initialization time.
/// </summary>
[ImplementableClass(true)]
internal static class InitializationHook
{
#pragma warning disable CS0169
  private static Type? __connectorType;
  private static Type? __connectorTypes;
#pragma warning restore CS0169

  private static InitializationHookConnector InstantiateConnector() => new();

  static InitializationHook()
  {
    BreeEngine.ProtoFluxBindings.ProtoFluxMapper.Initialize();
  }

  private sealed class InitializationHookConnector : IConnector
  {
#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
    public IImplementable? Owner { get; private set; }
#pragma warning restore CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).

    public void AssignOwner(IImplementable owner) => Owner = owner;

    public void RemoveOwner() => Owner = null;

    public void Initialize() { }

    public void ApplyChanges() { }

    public void Destroy(bool destroyingWorld) { }
  }
}