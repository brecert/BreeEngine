using System.Runtime.CompilerServices;
using Elements.Core;

namespace BreeEngine.TupleExtensions;

public static class TupleHelper
{
  public static bool IsTupleType(this Type type)
  {
    return typeof(ITuple).IsAssignableFrom(type);
  }

  public static int TupleSize(this Type type)
  {
    return type.GetGenericArguments().Sum(t => t.UnmanagedSizeOf());
  }

  public static bool IsValidTupleType(this Type type)
  {
    return type.IsTupleType() && type.TupleSize() < ReflectionExtensions.MAX_VALUE_SIZE;
  }
}