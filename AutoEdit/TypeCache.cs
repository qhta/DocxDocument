using System.Reflection;
using DocumentFormat.OpenXml;

namespace AutoEdit;

public static class TypeCache
{
  private static readonly Dictionary<string, Type?> _typeCache = new(StringComparer.Ordinal);
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.DocPart).Assembly;


  public static Type? ResolveType(string typeName)
  {
    if (TryResolveType(typeName, out var type))
    {
      return type;
    }
    throw new TypeLoadException($"Type '{typeName}' could not be found in assembly '{OpenXmlAssembly.FullName}'.");
  }

  public static bool TryResolveType(string typeName, out Type? type)
  {
    if (_typeCache.TryGetValue(typeName, out var cached))
    {
      type = cached!;
      return cached != null;
    }

    type = OpenXmlAssembly.GetType(typeName, throwOnError: false, ignoreCase: false);
    _typeCache[typeName] = type;
    return type != null;
  }
}