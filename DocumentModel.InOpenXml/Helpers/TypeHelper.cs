using System.Diagnostics;
using System.Reflection.Metadata;

namespace DocumentModel;

public static class TypeHelper
{
  public static Type? GetType(string? typeName)
  {
    if (string.IsNullOrEmpty(typeName))
      return null;


    var result = Assembly.GetAssembly(typeof(string))?.ExportedTypes.FirstOrDefault(t => t.Name == typeName);
    if (result == null)
      result = Assembly.GetAssembly(typeof(HexInt))?.ExportedTypes.FirstOrDefault(t => t.Name == typeName);
    if (result == null)
      result = Assembly.GetAssembly(typeof(TypeHelper))?.ExportedTypes.FirstOrDefault(t => t.Name == typeName);
    Debug.Assert(result is not null);
    return result;
  } 
}