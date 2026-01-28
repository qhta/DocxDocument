namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for Int16 value to/from Open XML.
/// </summary>
public static class Int16OpenXmlConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DX.SByteValue),
    typeof(DX.Int16Value),
    typeof(DX.Int32Value),
    typeof(DX.Int64Value),
    typeof(DX.IntegerValue),
    typeof(DX.ByteValue),
    typeof(DX.UInt16Value),
    typeof(DX.UInt32Value),
    typeof(DX.UInt64Value),
    typeof(DX.StringValue),
    typeof(DX.OpenXmlLeafTextElement),
    typeof(DX.OpenXmlLeafElement)
  ];


  /// <summary>
  /// Checks if the specified type is supported for Int16 conversion.
  /// It supports types derived from DX.OpenXmlLeafElement with an Int16 Val property
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
      if (valProp.PropertyType == typeof(Int16)
          || SupportsType(valProp.PropertyType))
        return true;

      return false;
    }

    return SupportedTypes.Contains(type);
  }

  #region SByteValue conversion.

  /// <summary>
  /// Converts an OpenXml SByteValue to Int16.
  /// </summary>
  /// <param name="SByteValue">The SByteValue to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.SByteValue? SByteValue)
  {
    if (SByteValue == null) return null;

    return SByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml SByteValue from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new SByteValue, or null if the input is null.</returns>
  public static DX.SByteValue? CreateSByteValue(Int16? value)
  {
    if (value == null) return null;
    if (value < SByte.MinValue || value > SByte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for SByte");

    return new DX.SByteValue { Value = (SByte)value };
  }

  #endregion

  #region Int16Value conversion.

  /// <summary>
  /// Converts an OpenXml Int16Value to Int16.
  /// </summary>
  /// <param name="Int16Value">The Int16Value to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.Int16Value? Int16Value)
  {
    if (Int16Value == null) return null;

    return Int16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int16Value from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new Int16Value, or null if the input is null.</returns>
  public static DX.Int16Value? CreateInt16Value(Int16? value)
  {
    if (value == null) return null;

    return new DX.Int16Value { Value = (Int16)value };
  }

  #endregion

  #region Int32Value conversion.

  /// <summary>
  /// Converts an OpenXml Int32Value to Int16.
  /// </summary>
  /// <param name="Int32Value">The Int32Value to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.Int32Value? Int32Value)
  {
    if (Int32Value == null) return null;
    if (Int32Value.Value< Int16.MinValue || Int32Value.Value > Int16.MaxValue)
      throw new OverflowException($"Value {Int32Value.Value} is out of range for Int16");

    return (Int16)Int32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int32Value from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new Int32Value, or null if the input is null.</returns>
  public static DX.Int32Value? CreateInt32Value(Int16? value)
  {
    if (value == null) return null;

    return new DX.Int32Value { Value = (Int16)value };
  }

  #endregion

  #region Int64Value conversion.

  /// <summary>
  /// Converts an OpenXml Int64Value to Int16.
  /// </summary>
  /// <param name="Int64Value">The Int64Value to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.Int64Value? Int64Value)
  {
    if (Int64Value == null) return null;
    if (Int64Value.Value < Int16.MinValue || Int64Value.Value > Int16.MaxValue)
      throw new OverflowException($"Value {Int64Value.Value} is out of range for Int16");

    return (Int16)Int64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml Int64Value from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new Int64Value, or null if the input is null.</returns>
  public static DX.Int64Value? CreateInt64Value(Int16? value)
  {
    if (value == null) return null;

    return new DX.Int64Value { Value = (Int64)value };
  }

  #endregion

  #region IntegerValue conversion.

  /// <summary>
  /// Converts an OpenXml IntegerValue to Int16.
  /// </summary>
  /// <param name="IntegerValue">The IntegerValue to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.IntegerValue? IntegerValue)
  {
    if (IntegerValue == null) return null;
    if (IntegerValue.Value < Int16.MinValue || IntegerValue.Value > Int16.MaxValue)
      throw new OverflowException($"Value {IntegerValue.Value} is out of range for Int16");

    return (Int16)IntegerValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static DX.IntegerValue? CreateIntegerValue(Int16? value)
  {
    if (value == null) return null;

    return new DX.IntegerValue { Value = (Int16)value };
  }

  #endregion

  #region ByteValue conversion.

  /// <summary>
  /// Converts an OpenXml ByteValue to Int16.
  /// </summary>
  /// <param name="ByteValue">The ByteValue to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.ByteValue? ByteValue)
  {
    if (ByteValue == null) return null;

    return ByteValue.Value;
  }

  /// <summary>
  /// Creates an OpenXml ByteValue from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new ByteValue, or null if the input is null.</returns>
  public static DX.ByteValue? CreateByteValue(Int16? value)
  {
    if (value == null) return null;
    if (value < 0 || value > Byte.MaxValue)
      throw new OverflowException($"Value {value} is out of range for Byte");

    return new DX.ByteValue { Value = (Byte)value };
  }

  #endregion

  #region UInt16Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt16Value to Int16.
  /// </summary>
  /// <param name="UInt16Value">The UInt16Value to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.UInt16Value? UInt16Value)
  {
    if (UInt16Value == null) return null;
    if (UInt16Value.Value > Int16.MaxValue)
      throw new OverflowException($"Value {UInt16Value.Value} is out of range for Int16");
    return (Int16)UInt16Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt16Value from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new UInt16Value, or null if the input is null.</returns>
  public static DX.UInt16Value? CreateUInt16Value(Int16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt16");

    return new DX.UInt16Value { Value = (UInt16)value };
  }

  #endregion

  #region UInt32Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt32Value to Int16.
  /// </summary>
  /// <param name="UInt32Value">The UInt32Value to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.UInt32Value? UInt32Value)
  {
    if (UInt32Value == null) return null;
    if ( UInt32Value.Value > Int16.MaxValue)
      throw new OverflowException($"Value {UInt32Value.Value} is out of range for Int16");

    return (Int16)UInt32Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt32Value from an UInt32 value.
  /// </summary>
  /// <param name="value">The UInt32 value to convert.</param>
  /// <returns>A new UInt32Value, or null if the input is null.</returns>
  public static DX.UInt32Value? CreateUInt32Value(Int16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt32");
    return new DX.UInt32Value { Value = (UInt32)value };
  }

  #endregion

  #region UInt64Value conversion.

  /// <summary>
  /// Converts an OpenXml UInt64Value to Int16.
  /// </summary>
  /// <param name="UInt64Value">The UInt64Value to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.UInt64Value? UInt64Value)
  {
    if (UInt64Value == null) return null;
    if (UInt64Value.Value > (UInt16)Int16.MaxValue)
      throw new OverflowException($"Value {UInt64Value.Value} is out of range for Int16");

    return (Int16)UInt64Value.Value;
  }

  /// <summary>
  /// Creates an OpenXml UInt64Value from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <returns>A new UInt64Value, or null if the input is null.</returns>
  public static DX.UInt64Value? CreateUInt64Value(Int16? value)
  {
    if (value == null) return null;
    if (value < 0)
      throw new OverflowException($"Value {value} is out of range for UInt64");
    return new DX.UInt64Value { Value = (UInt64)value };
  }

  #endregion

  #region StringValue conversion.

  /// <summary>
  /// Converts an OpenXml StringValue to Int16.
  /// </summary>
  /// <param name="StringValue">The StringValue to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.StringValue? StringValue)
  {
    if (StringValue == null) return null;
    var text = StringValue.Value;

    if (text == null)
      throw new InvalidOperationException("StringValue has no content.");

    return Int16.Parse(text);
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <param name="targetType">The target type for the created StringValue instance. Must be a subclass of StringValue.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static DX.StringValue? CreateStringValue(Int16? value, Type targetType)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    var element = (DX.StringValue)Activator.CreateInstance(targetType)!;
    element.Value = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement to Int16.
  /// </summary>
  /// <param name="OpenXmlLeafTextElement">The OpenXmlLeafTextElement to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.OpenXmlLeafTextElement? OpenXmlLeafTextElement)
  {
    if (OpenXmlLeafTextElement == null) return null;
    var text = OpenXmlLeafTextElement.Text;

    if (!Int16.TryParse(text, out var result))
      return null;

    return result;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafTextElement from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafTextElement instance. Must be a subclass of OpenXmlLeafTextElement.</param>
  /// <returns>A new OpenXmlLeafTextElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafTextElement? CreateOpenXmlLeafTextElement(Int16? value, Type targetType)
  {
    if (value == null) return null;

    var text = value.ToString()!;
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    element.Text = text;
    return element;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement to Int16.
  /// </summary>
  /// <param name="OpenXmlLeafElement">The OpenXmlLeafElement to convert.</param>
  /// <returns>The Int16 value, or null if the element has no content.</returns>
  public static Int16? ConvertToInt16(DX.OpenXmlLeafElement? OpenXmlLeafElement)
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
    if (valProp.PropertyType != typeof(Int16) && SupportsType(valProp.PropertyType))
    {
      var value = valProp.GetValue(OpenXmlLeafElement);
      var convertedValue = ConvertFromOpenXml(value);
      return (Int16)convertedValue!;
    }

    return (Int16)valProp.GetValue(OpenXmlLeafElement)!;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlLeafElement from an Int16 value.
  /// </summary>
  /// <param name="value">The Int16 value to convert.</param>
  /// <param name="targetType">The target type for the created OpenXmlLeafElement instance. Must be a subclass of OpenXmlLeafElement.</param>
  /// <returns>A new OpenXmlLeafElement, or null if the input is null.</returns>
  public static DX.OpenXmlLeafElement? CreateOpenXmlLeafElement(Int16? value, Type targetType)
  {
    if (value == null) return null;

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
    if (valProp.PropertyType != typeof(Int16) && SupportsType(valProp.PropertyType))
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
  public static object? ConvertToOpenXml(Int16? value, Type targetType)
  {
    if (value == null)
      return null;
    if (targetType == typeof(DX.SByteValue))
      return CreateSByteValue(value);
    if (targetType == typeof(DX.Int16Value))
      return CreateInt16Value(value);
    if (targetType == typeof(DX.Int32Value))
      return CreateInt32Value(value);
    if (targetType == typeof(DX.Int64Value))
      return CreateInt64Value(value);

    if (targetType == typeof(DX.IntegerValue))
      return CreateIntegerValue(value);

    if (targetType == typeof(DX.ByteValue))
      return CreateByteValue(value);
    if (targetType == typeof(DX.UInt16Value))
      return CreateUInt16Value(value);
    if (targetType == typeof(DX.UInt32Value))
      return CreateUInt32Value(value);
    if (targetType == typeof(DX.UInt64Value))
      return CreateUInt64Value(value);

    if (targetType == typeof(DX.StringValue))
      return CreateStringValue(value, targetType);

    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
      return CreateOpenXmlLeafTextElement(value, targetType);

    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafElement)))
      return CreateOpenXmlLeafElement(value, targetType);

    throw new InvalidOperationException($"Conversion from Int16 to {targetType} is not supported");
  }

  /// <summary>
  /// Converts an Open XML value to a nullable Int16 integer, if possible.
  /// </summary>
  /// <remarks>If value is a StringValue, the method attempts to parse its contents as an Int16 integer. If
  /// parsing fails, the method returns null.</remarks>
  /// <param name="value">The value to convert. Supported types include SByteValue, ByteValue, Int16Value, UInt16Value, Int32Value,
  /// UInt32Value, UInt64Value, and StringValue. May be null.</param>
  /// <returns>An Int16 representation of the input value, or null if the input is null or cannot be converted.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the type of value is not supported for conversion.</exception>
  public static Int16? ConvertFromOpenXml(object? value)
  {
    if (value == null)
      return null;

    var sourceType = value.GetType();
    if (value is DX.SByteValue sbyteValue)
      return ConvertToInt16(sbyteValue);
    if (value is DX.Int16Value int16Value)
      return ConvertToInt16(int16Value);
    if (value is DX.Int32Value int32Value)
      return ConvertToInt16(int32Value);
    if (value is DX.Int64Value int64Value)
      return ConvertToInt16(int64Value);

    if (value is DX.IntegerValue integerValue)
      return ConvertToInt16(integerValue);

    if (value is DX.ByteValue byteValue)
      return ConvertToInt16(byteValue);
    if (value is DX.UInt16Value uInt16Value)
      return ConvertToInt16(uInt16Value);
    if (value is DX.UInt32Value uintValue)
      return ConvertToInt16(uintValue);
    if (value is DX.UInt64Value uInt64Value)
      return ConvertToInt16(uInt64Value);

    if (value is DX.StringValue stringValue)
      return ConvertToInt16(stringValue);

    if (value is DX.OpenXmlLeafTextElement openXmlLeafTextElement)
      return ConvertToInt16(openXmlLeafTextElement);

    if (value is DX.OpenXmlLeafElement openXmlLeafElement)
      return ConvertToInt16(openXmlLeafElement);

    throw new InvalidOperationException($"Conversion from {sourceType} to Int16 is not supported");
  }

  #endregion
}