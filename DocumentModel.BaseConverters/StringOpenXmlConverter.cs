namespace DocumentModel.OpenXml;

/// <summary>
/// Provides helper methods for converting string values to and from OpenXml.
/// </summary>
public static class StringOpenXmlConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.StringValue),
    typeof(DXW.StringType),
    typeof(DXW.String255Type),
    typeof(DXW.String253Type),
    typeof(DX.OpenXmlLeafTextElement),
    typeof(DX.OpenXmlLeafElement),
    typeof(DX.EnumValue<>),
  ];

  /// <summary>
  /// Checks if the specified OpenXml type is supported for conversion to/from string.
  /// </summary>
  /// <param name="openXmlType">The OpenXml type to check.</param>
  /// <returns></returns>
  public static bool SupportsType(Type openXmlType)
  {
    if (openXmlType.IsGenericType)
    {
      var genericType = openXmlType.GetGenericTypeDefinition();
      if (SupportedTypes.Contains(genericType))
        return true;
    }
    else
    if (openXmlType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
    {
      return true;
    }
    else
    if (openXmlType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProperty = openXmlType.GetProperty("Val");
      if (valProperty != null && valProperty.PropertyType == typeof(DX.StringValue))
        return true;
    }
    else
    if (SupportedTypes.Contains(openXmlType))
      return true;

    return false;
  }

  #region StringValue conversion methods

  /// <summary>
  /// Retrieves the value of a StringValue as a nullable string.
  /// </summary>
  /// <param name="element">The StringValue to convert.</param>
  /// <returns>The string value or null if the element is null.</returns>
  public static string? GetValue(DX.StringValue? element)
  {
    return element?.Value;
  }

  /// <summary>
  /// Creates a StringValue from a nullable string.
  /// </summary>
  /// <param name="value">The string value.</param>
  /// <returns>A new StringValue containing the string, or null if the input string is null.</returns>
  public static DX.StringValue? CreateStringType(String? value)
  {
    if (value == null) return null;

    return new DX.StringValue { Value = value };
  }

  #endregion

  #region StringType conversion methods

  /// <summary>
  /// Retrieves the string value from a StringType element.
  /// </summary>
  /// <param name="element">The StringType element.</param>
  /// <returns>The string value, or null if result cannot be determined.</returns>
  public static string? GetValue(DXW.StringType? element)
  {
    if (element == null)
      return null;

    return element?.Val?.Value;
  }

  /// <summary>
  /// Creates an instance of StringType and sets its Val property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the created StringType instance. Must be a subclass of StringType.</param>
  /// <returns>Created StringType instance or null if element is null.</returns>
  public static DXW.StringType? CreateStringType(String? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.StringType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region String255Type conversion methods

  /// <summary>
  /// Retrieves the string value from a String255Type element.
  /// </summary>
  /// <param name="element">The String255Type element.</param>
  /// <returns>The string value, or null if result cannot be determined.</returns>
  public static string? GetValue(DXW.String255Type? element)
  {
    if (element == null) return null;

    return element.Val?.Value;
  }

  /// <summary>
  /// Creates an instance of String255Type and sets its Val property.
  /// </summary>
  /// <param name="value">The string value to set</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of String255Type.</param>
  /// <returns>Created String255Type instance or null if value is null.</returns>
  public static DXW.String255Type? CreateString255Type(String? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.String255Type)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region String253Type conversion methods

  /// <summary>
  /// Retrieves the string value from a String253Type element.
  /// </summary>
  /// <param name="element">The String253Type element.</param>
  /// <returns>The string value, or null if result cannot be determined.</returns>
  public static string? GetValue(DXW.String253Type? element)
  {
    if (element == null) return null;

    return element.Val?.Value;
  }

  /// <summary>
  /// Creates an instance of String253Type and sets its Val property.
  /// </summary>
  /// <param name="value">The string value to set</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of String253Type.</param>
  /// <returns>Created String253Type instance or null if value is null.</returns>
  public static DXW.String253Type? CreateString253Type(String? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.String253Type)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafTextElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static string? GetValue(DX.OpenXmlLeafTextElement? element)
  {
    if (element == null) return null;

    return element.Text;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafTextElement? CreateOpenXmlLeafTextElement(string? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = value;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXmlLeafElement.
  /// </summary>
  /// <param name="element">The OpenXmlLeafElement.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static string? GetValue(DX.OpenXmlLeafElement? element)
  {
    if (element == null) return null;

    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    var value = valProperty.GetValue(element);
    return value?.ToString();
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement and sets its value or text property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlLeafElement? CreateOpenXmlLeafElement(string? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Val' not found on {element.GetType().Name}");

    valProperty.SetValue(element, new DX.StringValue(value));
    return element;
  }

  #endregion

  #region OpenXmlSimpleType conversion methods

  /// <summary>
  /// Retrieves the text content from an OpenXml EnumValue.
  /// </summary>
  /// <param name="element">The OpenXml EnumValue.</param>
  /// <returns>The text content of the element, or null if the element is null.</returns>
  public static string? GetValue(DX.OpenXmlSimpleType? element)
  {
    if (element == null) return null;

    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Value' not found on {element.GetType().Name}");

    var value = valProperty.GetValue(element);
    return value?.ToString();
  }

  /// <summary>
  /// Creates an OpenXml EnumValue and sets its value or text property.
  /// </summary>
  /// <param name="value">The string value to set.</param>
  /// <param name="targetType">The target type for the created target instance. Must be a subclass of OpenXml EnumValue.</param>
  /// <returns>A new instance of the specified OpenXml element type with the value set.</returns>
  public static DX.OpenXmlSimpleType? CreateOpenXmlEnumValue(string? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlSimpleType)Activator.CreateInstance(targetType)!;
    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty == null)
      throw new InvalidOperationException($"Property 'Value' not found on {element.GetType().Name}");

    valProperty.SetValue(element, new DX.StringValue(value));
    return element;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts the specified string value to an Open XML object of the given target type.
  /// </summary>
  /// <remarks>Supported target types include subclasses of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, and OpenXmlLeafElement. The method returns null if the input value is
  /// null.</remarks>
  /// <param name="value">The string value to convert. If null, the method returns null.</param>
  /// <param name="targetType">The target Open XML type to convert the value to. Must be a subclass of a supported Open XML type.</param>
  /// <returns>An object representing the converted Open XML value, or null if the input value is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if the specified target type is not supported for conversion.</exception>
  public static object? ConvertToOpenXml(string? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.IsEqualOrSubclassOf(typeof(DX.StringValue)))
      return CreateStringType(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.StringType)))
      return CreateStringType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.String255Type)))
      return CreateString255Type(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.String253Type)))
      return CreateString253Type(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
      return CreateOpenXmlLeafTextElement(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return CreateOpenXmlLeafElement(value, targetType);
    if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(DX.EnumValue<>))
      return CreateOpenXmlEnumValue(value, targetType);

    throw new NotSupportedException($"Conversion from String to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an Open XML value to its string representation, if supported.
  /// </summary>
  /// <param name="value">The Open XML value to convert. This can be an instance of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, or OpenXmlLeafElement. May be null.</param>
  /// <returns>A string representation of the specified Open XML value, or null if <paramref name="value"/> is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if <paramref name="value"/> is not a supported Open XML type.</exception>
  public static string? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (value is DX.StringValue stringValue)
      return GetValue(stringValue);
    if (value is DXW.StringType stringTypeValue)
      return GetValue(stringTypeValue);
    if (value is DXW.String255Type string255Value)
      return GetValue(string255Value);
    if (value is DXW.String253Type string253Value)
      return GetValue(string253Value);
    if (value is DX.OpenXmlLeafTextElement textElement)
      return GetValue(textElement);
    if (value is DX.OpenXmlLeafElement leafElement)
      return GetValue(leafElement);
    
    if (sourceType.IsGenericType && sourceType.GetGenericTypeDefinition() == typeof(DX.EnumValue<>) && value is DX.OpenXmlSimpleType enumValue)
      return GetValue(enumValue);

    throw new NotSupportedException($"Conversion from type {sourceType} to String is not supported.");
  }

  #endregion
}