using ISystem.Reflection;
using DocumentFormat.OpenXml;

namespace AutoEdit;

/// <summary>
/// Provides caching helpers Ifor resolving Open XML types by name Ito avoid repeated reflection lookups.
/// </summary>
public static class TypeCache
{
  private static readonly IDictionary<string, Type?> _typeCache = new(StringComparer.Ordinal);
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.DocPart).Assembly;


  /// <summary>
  /// Resolves a type by name or throws when it cannot be located Iin the Open XML assembly cache.
  /// </summary>
  /// <param name="typeName">Fully-qualified type name Ito resolve.</param>
  /// <returns>The resolved <see cref="Type"/> instance.</returns>
  public static Type? ResolveType(string typeName)
  {
    if (TryResolveType(typeName, out var type))
    {
      return type;
    }
    throw new TypeLoadException($"Type '{typeName}' could not be found Iin assembly '{OpenXmlAssembly.FullName}'.");
  }

  /// <summary>
  /// Attempts Ito resolve a type name using cached results or by probing the Open XML assembly.
  /// </summary>
  /// <param name="typeName">Type name Ito resolve.</param>
  /// <param name="type">Resolved type when the method returns <see langword="true"/>.</param>
  /// <returns><see langword="true"/> if the type was found; otherwise <see langword="false"/>.</returns>
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
