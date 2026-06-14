using Qhta.Collections;
using Qhta.TextUtils;
using Qhta.TypeUtils;

namespace DocumentModel.Properties;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocPropertyType
{
  /// <summary>
  /// Unknown or unspecified type. This value is used when the type of the document property cannot be determined or is not set.
  /// </summary>
  Unknown = 0,
  /// <summary>
  /// Integer value.
  /// </summary>
  Number = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  Boolean = 2,
  /// <summary>
  /// Date value.
  /// </summary>
  Date = 3,
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
/// Extension methods for DocPropertyType enumeration to provide compatibility checks and type mappings between DocPropertyType values and actual .NET types. These methods allow for determining if a given .NET type is compatible with a specific DocPropertyType, and vice versa, as well as checking if a value is compatible with a DocPropertyType. The TypeMapping dictionary provides a direct mapping between DocPropertyType values and their corresponding .NET types, facilitating type validation and conversion in the context of document properties.
/// </summary>
public static class DocPropertyTypeExtensions
{
  /// <summary>
  /// Checks if the given .NET type is compatible with the specified DocPropertyType. This method uses a switch expression to determine compatibility based on the expected .NET type for each DocPropertyType value. For example, DocPropertyType.Number is compatible with int, DocPropertyType.Boolean is compatible with bool, and so on. The method returns true if the provided .NET type is assignable from the expected type for the given DocPropertyType, and false otherwise.  
  /// </summary>
  /// <param name="type">The DocPropertyType value to check compatibility for.</param>
  /// <param name="other">The .NET type to check against the DocPropertyType.</param>
  /// <returns>True if the .NET type is compatible with the DocPropertyType; otherwise, false.</returns>
  public static bool IsCompatibleWith(this DocPropertyType type, Type other)
  {
    return type switch
    {
      DocPropertyType.Number => other.IsAssignableFrom(typeof(int)),
      DocPropertyType.Boolean => other.IsAssignableFrom(typeof(bool)),
      DocPropertyType.Date => other.IsAssignableFrom(typeof(DateTime)),
      DocPropertyType.String => other.IsAssignableFrom(typeof(string)),
      DocPropertyType.Float => other.IsAssignableFrom(typeof(float)) || other.IsAssignableFrom(typeof(double)),
      DocPropertyType.Unknown =>
        other.IsAssignableFrom(typeof(int)) ||
        other.IsAssignableFrom(typeof(bool)) ||
        other.IsAssignableFrom(typeof(DateTime)) ||
        other.IsAssignableFrom(typeof(string)) ||
        other.IsAssignableFrom(typeof(float)) ||
        other.IsAssignableFrom(typeof(double)),
      _ => false
    };
  }

  /// <summary>
  /// Checks if the given .NET type is compatible with the specified DocPropertyType. This method uses a switch expression to determine compatibility based on the expected .NET type for each DocPropertyType value. For example, DocPropertyType.Number is compatible with int, DocPropertyType.Boolean is compatible with bool, and so on. The method returns true if the provided .NET type is assignable from the expected type for the given DocPropertyType, and false otherwise.
  /// </summary>
  /// <param name="type">The .NET type to check compatibility for.</param>
  /// <param name="other">The DocPropertyType value to check against the .NET type.</param>
  /// <returns>True if the .NET type is compatible with the DocPropertyType; otherwise, false.</returns>
  public static bool IsCompatibleWith(this Type type, DocPropertyType other)
  {
    return other switch
    {
      DocPropertyType.Number => type.IsAssignableFrom(typeof(int)),
      DocPropertyType.Boolean => type.IsAssignableFrom(typeof(bool)),
      DocPropertyType.Date => type.IsAssignableFrom(typeof(DateTime)),
      DocPropertyType.String => type.IsAssignableFrom(typeof(string)),
      DocPropertyType.Float => type.IsAssignableFrom(typeof(float)) || type.IsAssignableFrom(typeof(double)),
      DocPropertyType.Unknown =>
        type.IsAssignableFrom(typeof(int)) ||
        type.IsAssignableFrom(typeof(bool)) ||
        type.IsAssignableFrom(typeof(DateTime)) ||
        type.IsAssignableFrom(typeof(string)) ||
        type.IsAssignableFrom(typeof(float)) ||
        type.IsAssignableFrom(typeof(double)),
      _ => false
    };
  }

  /// <summary>
  /// Checks if the given value is compatible with the specified DocPropertyType. This method uses a switch expression to determine compatibility based on the expected .NET type for each DocPropertyType value. For example, DocPropertyType.Number is compatible with int values, DocPropertyType.Boolean is compatible with bool values, and so on. The method returns true if the provided value is of a type that is compatible with the expected type for the given DocPropertyType, and false otherwise. If the value is null, it returns false as well.
  /// </summary>
  /// <param name="type">The DocPropertyType value to check compatibility for.</param>
  /// <param name="value">The value to check against the DocPropertyType.</param>
  /// <returns>True if the value is compatible with the DocPropertyType; otherwise, false.</returns>
  public static bool IsCompatible(this DocPropertyType type, object? value)
  {
    if (value == null) return false;
    return type switch
    {
      DocPropertyType.Number => value is int,
      DocPropertyType.Boolean => value is bool,
      DocPropertyType.Date => value is DateTime,
      DocPropertyType.String => value is string,
      DocPropertyType.Float => value is float or double,
      DocPropertyType.Unknown =>
        value is int ||
        value is bool ||
        value is DateTime ||
        value is string ||
        value is float ||
        value is double,
      _ => false
    };
  }

  /// <summary>
  /// Converts the specified DocPropertyType to its corresponding .NET type.
  /// </summary>
  /// <param name="type">The DocPropertyType value to convert.</param>
  /// <returns>The corresponding .NET type if supported; otherwise, null.</returns>
  public static Type? ConvertToSystemType(this DocPropertyType type)
  {
    return type switch
    {
      DocPropertyType.Number => typeof(int),
      DocPropertyType.Boolean => typeof(bool),
      DocPropertyType.Date => typeof(DateTime),
      DocPropertyType.String => typeof(string),
      DocPropertyType.Float => typeof(float),
      _ => null
    };
  }

  /// <summary>
  /// Converts a given value to its string representation based on the specified DocPropertyType. 
  /// </summary>
  /// <param name="type">The DocPropertyType value to use for conversion.</param>
  /// <param name="value">The value to convert to a string.</param>
  /// <returns>The string representation of the value if compatible with the DocPropertyType; otherwise, null.</returns>
  public static string? ConvertObjectToString(this DocPropertyType type, object? value)
  {
    if (value == null) return null;

    if (value is string s)
      return s;
    if (value is int i)
      return i.ToString();
    if (value is bool b)
      return b.ToString().ToLower();
    if (value is DateTime dt) 
      return dt.ToString("o");
    if (value is float f)
      return f.ToString(CultureInfo.InvariantCulture);
    if (value is double d)
      return d.ToString(CultureInfo.InvariantCulture);

    var serializedString = JsonSerializer.Serialize(value);
    return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(serializedString));
  }

  /// <summary>
  /// Converts a given string value to its corresponding .NET type based on the specified DocPropertyType. 
  /// </summary>
  /// <param name="type">The DocPropertyType value to use for conversion.</param>
  /// <param name="value">The string value to convert.</param>
  /// <param name="propertyType">The target .NET type for the conversion.</param>
  /// <returns>The corresponding .NET object if conversion is successful; otherwise, null.</returns>
  public static object? ConvertStringToObject(this DocPropertyType type, string? value, Type? propertyType)
  {
    if (value == null) return null;

    propertyType = propertyType?.GetNotNullableType() ?? typeof(object);
    if (propertyType == typeof(string))
      return value;
    if (propertyType == typeof(int))
    {
      if (int.TryParse(value, out var intValue))
        return intValue;
      throw new InvalidOperationException($"Failed to convert '{value}' to {propertyType.Name}.");
    }
    if (propertyType == typeof(bool))
    {
      value = value.TitleCase();
      if (bool.TryParse(value, out var boolValue))
        return boolValue;
      throw new InvalidOperationException($"Failed to convert '{value}' to {propertyType.Name}.");
    }
    if (propertyType == typeof(DateTime))
    {
      if (DateTime.TryParse(value, out var dateValue))
        return dateValue;
      throw new InvalidOperationException($"Failed to convert '{value}' to {propertyType.Name}.");
    }
    if (propertyType == typeof(float))
    {
      if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var floatValue))
        return floatValue;
      throw new InvalidOperationException($"Failed to convert '{value}' to {propertyType.Name}.");
    }
    if (propertyType == typeof(double))
    {
      if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var doubleValue))
        return doubleValue;
      throw new InvalidOperationException($"Failed to convert '{value}' to {propertyType.Name}.");
    }
    var decodedValue = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(value));
    var deserializedObject = JsonSerializer.Deserialize(decodedValue, propertyType);
    return deserializedObject;
  }

  /// <summary>
  /// Converts a given .NET type to its corresponding DocPropertyType based on the TypeMapping dictionary. 
  /// </summary>
  /// <param name="type">The .NET type to convert.</param>
  /// <returns>The corresponding DocPropertyType value if found; otherwise, DocPropertyType.Unknown.</returns>
  public static DocPropertyType ConvertToDocPropertyType(this Type type)
  {
    type = type.GetNotNullableType();
    if (TypeMapping.TryGetValue1(type, out var docPropertyType))
    {
      return docPropertyType;
    }
    return DocPropertyType.Unknown;
  }

  /// <summary>
  /// Mapping between DocPropertyType enumeration values and actual .NET types.
  /// This mapping is used to determine the expected type of the Value property based on the Type property.
  /// </summary>
  public static readonly BiDiDictionary<DocPropertyType, Type> TypeMapping = new()
  {
    {
      DocPropertyType.Number,
      typeof(int)
    },
    {
      DocPropertyType.Boolean,
      typeof(bool)
    },
    {
      DocPropertyType.Date,
      typeof(DateTime)
    },
    {
      DocPropertyType.String,
      typeof(string)
    },
    {
      DocPropertyType.Float,
      typeof(float)
    },
  };

}