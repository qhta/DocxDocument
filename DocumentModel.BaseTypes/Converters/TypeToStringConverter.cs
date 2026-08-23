using System.Reflection;

namespace DocumentModel;

/// <summary>
/// Converter class for converting System.Type objects to their string representation and vice versa. This class maintains a cache of known types from specified assemblies to optimize the conversion process. It provides methods to register assemblies for type lookup and to convert Type objects to their full name as a string, as well as to convert a string back to a Type object by searching through the registered assemblies. This converter is particularly useful in scenarios where type information needs to be serialized or deserialized, such as in JSON or XML serialization of document properties that may have varying types.
/// </summary>
public abstract class TypeToStringConverter
{
  private static readonly List<Assembly> _assemblies = new List<Assembly>
  {
    Assembly.GetAssembly(typeof(string))!,
  };

  private static readonly Dictionary<string, Type> _knownTypes = new Dictionary<string, Type>();

  /// <summary>
  /// Adds an assembly to the list of assemblies that are searched when converting a string to a Type. This allows the converter to recognize types from that assembly during deserialization. If the assembly is already registered, it will not be added again.
  /// </summary>
  /// <param name="assembly">The assembly to register.</param>
  /// <exception cref="ArgumentNullException">Thrown if the assembly is null.</exception>
  public static void RegisterAssembly(Assembly assembly)
  {
    if (assembly == null) throw new ArgumentNullException(nameof(assembly));
    if (!_assemblies.Contains(assembly))
    {
      _assemblies.Add(assembly);
    }
  }

  /// <summary>
  /// Registers a specific Type in the cache of known types. This allows the converter to quickly resolve the type by its name during deserialization without needing to search through the registered assemblies. If the type is already registered, it will be updated with the new Type object.
  /// </summary>
  /// <param name="type"></param>
  public static void RegisterType(Type type)
  {
    _knownTypes[type.Name] = type;
  }
  /// <summary>
  /// Converts a type name to a Type object by searching through the registered assemblies. It first checks the cache of known types, and if not found, it iterates through the registered assemblies to find the type. If the type is found, it is added to the cache for future lookups. If the type cannot be found in any of the registered assemblies, a TypeLoadException is thrown.
  /// </summary>
  /// <param name="typeName">The name of the type to resolve.</param>
  /// <returns>The resolved Type object.</returns>
  /// <exception cref="TypeLoadException">Thrown if the type cannot be found in the registered assemblies.</exception>
  public static Type ResolveType(string typeName)
  {
    if (_knownTypes.TryGetValue(typeName, out var type))
    {
      return type;
    }
    foreach (var assembly in _assemblies)
    {
      type = assembly.GetType(typeName);
      if (type != null)
      {
        _knownTypes[typeName] = type;
        return type;
      }
    }
    throw new TypeLoadException($"Type '{typeName}' could not be found in registered assemblies.");
  }

  /// <summary>
  /// Abstract method that must be implemented by derived classes to convert an object to its string representation.
  /// The implementation should handle the conversion logic specific to the type of object being converted.
  /// If the val is null, the method should return null.
  /// This method is intended to be used in scenarios where type information needs to be serialized or logged as a string.
  /// </summary>
  /// <param name="val">The object to convert to a string.</param>
  /// <returns>The string representation of the object, or null if the object is null.</returns>
  public abstract string? ConvertToString(object? val);

  /// <summary>
  /// Abstract method that must be implemented by derived classes to convert a string representation back to an object.
  /// The implementation should handle the conversion logic specific to the type of object being converted.
  /// If the str is null, the method should return null.
  /// This method is intended to be used in scenarios where type information needs to be deserialized or reconstructed from a string.
  /// </summary>
  /// <param name="str">The string representation of the object to convert.</param>
  /// <returns>The converted object, or null if the string is null.</returns>
  public abstract object? ConvertFromString(string? str);
}