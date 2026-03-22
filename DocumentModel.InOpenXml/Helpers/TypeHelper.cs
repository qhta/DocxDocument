using System.Reflection.Metadata;
namespace DocumentModel;
/// <summary>
///   Provides utility methods for resolving and working with .NET types by name at runtime.
/// </summary>
public static class TypeHelper
{
  /// <summary>
  ///   Attempts to resolve a type by its name from known assemblies, including core types and project-specific types.
  /// </summary>
  /// <param name="typeName">The simple name of the type to resolve (case-sensitive).</param>
  /// <returns>The resolved <see cref="Type"/> if found; otherwise, null.</returns>
  public static Type? GetType(string? typeName)
  {
    if (string.IsNullOrEmpty(typeName))
      return null;
    var result = Assembly.GetAssembly(typeof(string))?.ExportedTypes.FirstOrDefault(t => t.Name == typeName);
    if (result == null)
      result = Assembly.GetAssembly(typeof(HexInt))?.ExportedTypes.FirstOrDefault(t => t.Name == typeName);
    if (result == null)
      result = Assembly.GetAssembly(typeof(TypeHelper))?.ExportedTypes.FirstOrDefault(t => t.Name == typeName);
    if (result == null)
    {
      if (typeName=="Byte[]")
        return typeof(byte[]);
    }
    Debug.Assert(result is not null);
    return result;
  } 
}