
namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Twips values (hexadecimal integers) in Open XML.
/// </summary>
public static class TwipsOpenXmlConverter
{

  /// <summary>
  /// Gets the supported Open XML types for conversion.
  /// </summary>
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.Int32Value),
    typeof(DX.UInt32Value),
    typeof(DX.StringValue),
    typeof(DX.OpenXmlLeafTextElement),
    typeof(DX.OpenXmlLeafElement)
  ];


  /// <summary>
  /// Checks if the specified type is supported for Int32 conversion.
  /// It supports types derived from DX.OpenXmlLeafElement with an Int32 or UInt32 Val property
  /// or a singular property of one of the supported types,
  /// or types in the SupportedTypes list.
  /// </summary>
  /// <param name="type">The type to check.</param>
  /// <returns>True if and only if the conversion to/from OpenXml type is supported.</returns>
  public static bool SupportsType(Type type)
  {
    if (type.IsSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
      return true;
    if (type.IsSubclassOf(typeof(DX.OpenXmlLeafElement)))
    {
      var valProp = type.GetProperty("Val");
      if (valProp == null)
      {
        var allProps = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        if (allProps.Length == 1)
          valProp = allProps[0];
        else
          return false;

      }
      if (valProp.PropertyType == typeof(UInt32) || valProp.PropertyType == typeof(Int32)
          || SupportsType(valProp.PropertyType))
        return true;

      return false;
    }

    return SupportedTypes.Contains(type);
  }

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Twips.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  public static Twips? ConvertToTwips(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;

    return (Twips)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? CreateInt32Value(Twips? value)
  {
    if (value is null) return null;

    if ((Int64)value < Int32.MinValue || (Int64)value > Int32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Int32");

    return new DX.Int32Value { Value = (Int32)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Twips.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  public static Twips? ConvertToTwips(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;

    return (Twips)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? CreateUInt32Value(Twips? value)
  {
    if (value is null) return null;

    if ((Int64)value < 0 ||(Int64)value > UInt32.MaxValue)
      throw new OverflowException($"Value {value} is out of range for UInt32");

    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to Twips.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  public static Twips? ConvertToTwips(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;
    var text = StringValue.Value;

    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return new Twips(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? CreateStringValue(Twips? value, Type targetType)
  {
    if (value is null) return null;

    var text = value.ToString()!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion


  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Twips.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  public static Twips? ConvertToTwips(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;
    var text = OpenXmlLeafTextElement.Text;

    return new Twips(text);
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? CreateOpenXmlLeafTextElement(Twips? value, Type targetType)
  {
    if (value is null) return null;

    var text = ((Twips)value).ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement to Twips.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The Twips value, or null if the element has no content.</returns>
  public static Twips? ConvertToTwips(DX.OpenXmlLeafElement? OpenXmlLeafElement)
  {
    if (OpenXmlLeafElement == null) return null;

    var sourceType = OpenXmlLeafElement.GetType();
    var valProp = OpenXmlLeafElement.GetType().GetProperty("Val");
    if (valProp == null)
    {
      var allProps = sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        throw new InvalidOperationException($"OpenXmlLeafElement of type {sourceType} does not have a string Val property");
    }
    if (valProp.PropertyType != typeof(UInt32) && valProp.PropertyType != typeof(Int32) && SupportsType(valProp.PropertyType))
    {
      var value = valProp.GetValue(OpenXmlLeafElement);
      var convertedValue = ConvertFromOpenXml(value);
      return (Twips)convertedValue!;
    }

    return (Twips)valProp.GetValue(OpenXmlLeafElement)!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Twips value.
  /// </summary>
  /// <param name="value">The Twips value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? CreateOpenXmlLeafElement(Twips? value, Type targetType)
  {
    if (value is null) return null;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProp = element.GetType().GetProperty("Val");
    if (valProp == null)
    {
      var allProps = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
      if (allProps.Length == 1)
        valProp = allProps[0];
      else
        throw new InvalidOperationException($"OpenXmlLeafElement of type {element.GetType()} does not have a string Val property");
    }
    if (valProp.PropertyType != typeof(UInt32) && valProp.PropertyType != typeof(Int32) && SupportsType(valProp.PropertyType))
    {
      var convertedValue = ConvertToOpenXml(value, valProp.PropertyType);
      valProp.SetValue(element, convertedValue);
      return element;
    }
    valProp.SetValue(element, value);
    return element;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts a value to a specified target type.
  /// </summary>
  /// <param name="value">The value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>The converted value, or null if the element has no content.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the conversion is not supported.</exception>
  public static object? ConvertToOpenXml(Twips? value, Type targetType)
  {
    if (value is null)
      return null;
    if (targetType == typeof(DX.Int32Value))
      return CreateInt32Value(value);
    if (targetType == typeof(DX.UInt32Value))
      return CreateUInt32Value(value);

    if (targetType == typeof(DX.StringValue))
      return CreateStringValue(value, targetType);

    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
      return CreateOpenXmlLeafTextElement(value, targetType);

    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return CreateOpenXmlLeafElement(value, targetType);

    throw new InvalidOperationException($"Conversion from Twips to {targetType} is not supported");
  }

  /// <summary>
  /// Converts an Open XML value to a nullable Twips integer, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an Twips integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int32Value,
  /// TwipsValue, UInt64Value, and StringValue. May be null.</param>
  /// <returns>An Twips representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Twips? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.Int32Value int32Value)
      return ConvertToTwips(int32Value);
    if (value is DX.UInt32Value uintValue)
      return ConvertToTwips(uintValue);

    if (value is DX.StringValue stringValue)
      return ConvertToTwips(stringValue);

    if (value is DX.OpenXmlLeafTextElement openXmlLeafTextElement)
      return ConvertToTwips(openXmlLeafTextElement);

    if (value is DX.OpenXmlLeafElement openXmlLeafElement)
      return ConvertToTwips(openXmlLeafElement);

    throw new InvalidOperationException($"Conversion from {sourceType} to Twips is not supported");
  }

  #endregion
}