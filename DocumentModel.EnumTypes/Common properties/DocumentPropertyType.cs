using Qhta.Collections;
using Qhta.TextUtils;
using Qhta.TypeUtils;

namespace DocumentModel.Properties;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentPropertyType
{
  /// <summary>
  /// Unknown or unspecified type. This value is used when the type of the document property cannot be determined or is not set.
  /// </summary>
  Unknown = 0,
  /// <summary>
  /// Integer value.
  /// </summary>
  Integer = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  Boolean = 2,
  /// <summary>
  /// Date value.
  /// </summary>
  DateTime = 3,
  /// <summary>
  /// String value.
  /// </summary>
  String = 4,
  /// <summary>
  /// Floating point value.
  /// </summary>
  Float = 5
}


/// <summary>
/// Extension methods for DocumentPropertyType enumeration to provide compatibility checks and type mappings between DocumentPropertyType values and actual .NET types. These methods allow for determining if a given .NET type is compatible with a specific DocumentPropertyType, and vice versa, as well as checking if a value is compatible with a DocumentPropertyType. The TypeMapping dictionary provides a direct mapping between DocumentPropertyType values and their corresponding .NET types, facilitating type validation and conversion in the context of document properties.
/// </summary>
public static class DocumentPropertyTypeExtensions
{
  /// <summary>
  /// Checks if the given .NET type is compatible with the specified DocumentPropertyType. This method uses a switch expression to determine compatibility based on the expected .NET type for each DocumentPropertyType value. For example, DocumentPropertyType.Number is compatible with int, DocumentPropertyType.Boolean is compatible with bool, and so on. The method returns true if the provided .NET type is assignable from the expected type for the given DocumentPropertyType, and false otherwise.  
  /// </summary>
  /// <param name="type">The DocumentPropertyType value to check compatibility for.</param>
  /// <param name="other">The .NET type to check against the DocumentPropertyType.</param>
  /// <returns>True if the .NET type is compatible with the DocumentPropertyType; otherwise, false.</returns>
  public static bool IsCompatibleWith(this DocumentPropertyType type, Type other)
  {
    return type switch
    {
      DocumentPropertyType.Integer => other.IsAssignableFrom(typeof(int)),
      DocumentPropertyType.Boolean => other.IsAssignableFrom(typeof(bool)),
      DocumentPropertyType.DateTime => other.IsAssignableFrom(typeof(DateTime)),
      DocumentPropertyType.String => other.IsAssignableFrom(typeof(string)),
      DocumentPropertyType.Float => other.IsAssignableFrom(typeof(float)),
      DocumentPropertyType.Unknown =>
        other.IsAssignableFrom(typeof(int)) ||
        other.IsAssignableFrom(typeof(bool)) ||
        other.IsAssignableFrom(typeof(DateTime)) ||
        other.IsAssignableFrom(typeof(string)) ||
        other.IsAssignableFrom(typeof(float)),
      _ => false
    };
  }

  /// <summary>
  /// Checks if the given .NET type is compatible with the specified DocumentPropertyType. This method uses a switch expression to determine compatibility based on the expected .NET type for each DocumentPropertyType value. For example, DocumentPropertyType.Number is compatible with int, DocumentPropertyType.Boolean is compatible with bool, and so on. The method returns true if the provided .NET type is assignable from the expected type for the given DocumentPropertyType, and false otherwise.
  /// </summary>
  /// <param name="type">The .NET type to check compatibility for.</param>
  /// <param name="other">The DocumentPropertyType value to check against the .NET type.</param>
  /// <returns>True if the .NET type is compatible with the DocumentPropertyType; otherwise, false.</returns>
  public static bool IsCompatibleWith(this Type type, DocumentPropertyType other)
  {
    return other switch
    {
      DocumentPropertyType.Integer => type.IsAssignableFrom(typeof(int)),
      DocumentPropertyType.Boolean => type.IsAssignableFrom(typeof(bool)),
      DocumentPropertyType.DateTime => type.IsAssignableFrom(typeof(DateTime)),
      DocumentPropertyType.String => type.IsAssignableFrom(typeof(string)),
      DocumentPropertyType.Float => type.IsAssignableFrom(typeof(float)),
      DocumentPropertyType.Unknown =>
        type.IsAssignableFrom(typeof(int)) ||
        type.IsAssignableFrom(typeof(bool)) ||
        type.IsAssignableFrom(typeof(DateTime)) ||
        type.IsAssignableFrom(typeof(string)) ||
        type.IsAssignableFrom(typeof(float)),
      _ => false
    };
  }

  /// <summary>
  /// Checks if the given value is compatible with the specified DocumentPropertyType. This method uses a switch expression to determine compatibility based on the expected .NET type for each DocumentPropertyType value. For example, DocumentPropertyType.Number is compatible with int values, DocumentPropertyType.Boolean is compatible with bool values, and so on. The method returns true if the provided value is of a type that is compatible with the expected type for the given DocumentPropertyType, and false otherwise. If the value is null, it returns false as well.
  /// </summary>
  /// <param name="type">The DocumentPropertyType value to check compatibility for.</param>
  /// <param name="value">The value to check against the DocumentPropertyType.</param>
  /// <returns>True if the value is compatible with the DocumentPropertyType; otherwise, false.</returns>
  public static bool IsCompatible(this DocumentPropertyType type, object? value)
  {
    if (value == null) return false;
    return type switch
    {
      DocumentPropertyType.Integer => value is int,
      DocumentPropertyType.Boolean => value is bool,
      DocumentPropertyType.DateTime => value is DateTime,
      DocumentPropertyType.String => value is string,
      DocumentPropertyType.Float => value is float,
      DocumentPropertyType.Unknown =>
        value is int ||
        value is bool ||
        value is DateTime ||
        value is string ||
        value is float,
      _ => false
    };
  }

  /// <summary>
  /// Converts the specified DocumentPropertyType to its corresponding .NET type.
  /// </summary>
  /// <param name="type">The DocumentPropertyType value to convert.</param>
  /// <returns>The corresponding .NET type if supported; otherwise, null.</returns>
  public static Type? ConvertToSystemType(this DocumentPropertyType type)
  {
    return type switch
    {
      DocumentPropertyType.Integer => typeof(int),
      DocumentPropertyType.Boolean => typeof(bool),
      DocumentPropertyType.DateTime => typeof(DateTime),
      DocumentPropertyType.String => typeof(string),
      DocumentPropertyType.Float => typeof(float),
      _ => null
    };
  }

  /// <summary>
  /// Converts a given .NET type to its corresponding DocumentPropertyType based on the TypeMapping dictionary. 
  /// </summary>
  /// <param name="type">The .NET type to convert.</param>
  /// <returns>The corresponding DocumentPropertyType value if found; otherwise, DocumentPropertyType.Unknown.</returns>
  public static DocumentPropertyType ConvertToDocumentPropertyType(this Type type)
  {
    type = type.GetNotNullableType();
    if (TypeMapping.TryGetValue1(type, out var DocumentPropertyType))
    {
      return DocumentPropertyType;
    }
    return DocumentPropertyType.Unknown;
  }

  /// <summary>
  /// Mapping between DocumentPropertyType enumeration values and actual .NET types.
  /// This mapping is used to determine the expected type of the Value property based on the Type property.
  /// </summary>
  public static readonly BiDiDictionary<DocumentPropertyType, Type> TypeMapping = new()
  {
    {
      DocumentPropertyType.Integer,
      typeof(int)
    },
    {
      DocumentPropertyType.Boolean,
      typeof(bool)
    },
    {
      DocumentPropertyType.DateTime,
      typeof(DateTime)
    },
    {
      DocumentPropertyType.String,
      typeof(string)
    },
    {
      DocumentPropertyType.Float,
      typeof(float)
    },
  };

}