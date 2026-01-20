namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for integer values in Open XML.
/// </summary>
public static class IntValueConverter
{
  public static object? CreateOpenXmlElement(int value, Type elementType)
  {
    if (elementType == typeof(Int32Value))
      return new Int32Value(value);
    if (elementType == typeof(UInt16Value))
      return new UInt16Value((UInt16)value);

    throw new InvalidOperationException($"Conversion to {elementType} is not supported.");
  }


  #region CompositeElement Int get/set methods

  /// <summary>
  /// Retrieves an integer value from a child element within an OpenXmlCompositeElement.
  /// The returned integer type is specified as a type parameter.
  /// The property name to read from can be explicitly specified (default is "Val").
  /// </summary>
  /// <typeparam name="IntegerType">The target integer type (e.g., Int32, UInt32).</typeparam>
  /// <typeparam name="OpenXmlElementType">The type of the child OpenXml element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="propName">The name of the property to read. Default is "Val".</param>
  /// <returns>The converted integer value, or null if the element or property is missing.</returns>
  public static IntegerType? GetIntVal<IntegerType, OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement,
    string? propName = null)
    where IntegerType : struct, IConvertible
    where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element != null)
      {
        if (propName == null) propName = "Val";
        var valProperty = typeof(OpenXmlElementType).GetProperty(propName);
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value != null)
          {
            IntegerType n = (IntegerType)Convert.ChangeType(value, typeof(IntegerType));
            return n;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets an integer value in the OpenXmlCompositeElement by updating or creating the specified OpenXmlElementType child element.
  /// The property name to write to can be explicitly specified (default is "Val").
  /// </summary>
  /// <typeparam name="IntegerType">The type of the input integer value.</typeparam>
  /// <typeparam name="OpenXmlElementType">The type of the child OpenXml element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The integer value to set. If null, the child element is removed.</param>
  /// <param name="propName">The name of the property to write. Default is "Val".</param>
  /// <exception cref="InvalidCastException">Thrown if the value cannot be converted to the target property type.</exception>
  public static void SetIntVal<IntegerType, OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, IntegerType? value,
    string? propName = null)
    where IntegerType : struct, IConvertible
    where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element == null)
      {
        element = new OpenXmlElementType();
        openXmlElement.AppendChild(element);
      }
      if (propName == null) propName = "Val";
      var valProperty = typeof(OpenXmlElementType).GetProperty(propName);
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(Int32Value))
      {
        var valInt = (Int32)Convert.ChangeType(value, typeof(Int32));
        var val = new Int32Value(valInt);
        valProperty.SetValue(element, val);
      }
      else
      if (valType == typeof(UInt32Value))
      {
        var valInt = (UInt32)Convert.ChangeType(value, typeof(UInt32));
        var val = new UInt32Value(valInt);
        valProperty.SetValue(element, val);
      }
      else
      if (valType == typeof(Int16Value))
      {
        var valInt = (Int16)Convert.ChangeType(value, typeof(Int16));
        var val = new Int16Value(valInt);
        valProperty.SetValue(element, val);
      }
      else
      if (valType == typeof(UInt16Value))
      {
        var valInt = (UInt16)Convert.ChangeType(value, typeof(UInt16));
        var val = new UInt16Value(valInt);
        valProperty.SetValue(element, val);
      }
      else
      if (valType == typeof(StringValue))
      {
        var valStr = value.ToString();
        var val = new StringValue(valStr);
        valProperty.SetValue(element, val);
      }
      else
      if (valType == typeof(IntegerValue))
      {
        var valLong = (long)Convert.ChangeType(value, typeof(long));
        var val = new IntegerValue(valLong);
        valProperty.SetValue(element, val);
      }
      else
        throw new InvalidCastException($"Can't set int value to {valType} property");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  #endregion


  #region HpsMeasureType conversion.
  /// <summary>
  /// Converts an HpsMeasureType value to Int32.
  /// </summary>
  /// <param name="hpsValue">The HpsMeasureType element to convert.</param>
  /// <returns>The Int32 value of the element content, or null if empty or conversion is impossible.</returns>
  public static Int32? GetValue(DXW.HpsMeasureType? hpsValue)
  {
    if (hpsValue?.Val != null)
    {
      if (Int32.TryParse(hpsValue.Val, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Sets a specific OpenXml HpsMeasureType element value based on an Int32 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The specific HpsMeasureType subclass.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The value to set. If null, the element is removed.</param>
  public static void SetHpsMeasureType<OpenXmlElementType>(OpenXmlCompositeElement openXmlElement, Int32? value)
    where OpenXmlElementType : DXW.HpsMeasureType, new()
  {
    var element = openXmlElement.GetFirstChild<OpenXmlElementType>();
    if (element != null && value != null)
    {
      element.Val = ((Int32)value).ToString();
    }
    else if (element == null && value != null)
    {
      element = new OpenXmlElementType();
      element.Val = ((Int32)value).ToString();
      openXmlElement.AppendChild(element);
    }
    else if (element != null && value == null)
    {
      element.Remove();
    }
  }
  #endregion

  #region IntegerValue conversion.
  /// <summary>
  /// Converts an OpenXml IntegerValue to Int32.
  /// </summary>
  /// <param name="integerValue">The IntegerValue to convert.</param>
  /// <returns>The Int32 value, or null if the element has no content.</returns>
  public static Int32? GetValue(IntegerValue? integerValue)
  {
    if (integerValue?.Value != null)
    {
      return (Int32)integerValue.Value;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml IntegerValue from an Int32 value.
  /// </summary>
  /// <param name="value">The Int32 value to convert.</param>
  /// <returns>A new IntegerValue, or null if the input is null.</returns>
  public static IntegerValue? CreateIntegerValue(Int32? value)
  {
    if (value == null) return null;
    return new IntegerValue { Value = (Int32)value };
  }
  #endregion

  #region StringValue conversion.
  /// <summary>
  /// Converts an OpenXml StringValue to Int32.
  /// </summary>
  /// <param name="stringValue">The StringValue to convert.</param>
  /// <returns>The Int32 value, or null if the element has no content or conversion fails.</returns>
  public static Int32? GetValue(StringValue? stringValue)
  {
    if (stringValue?.Value != null)
    {
      if (Int32.TryParse(stringValue.Value, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml StringValue from an Int32 value.
  /// </summary>
  /// <param name="value">The Int32 value to convert.</param>
  /// <returns>A new StringValue, or null if the input is null.</returns>
  public static StringValue? CreateStringValue(Int32? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }

  /// <summary>
  /// Sets an Int32 value as a string on a specific OpenXml leaf element property.
  /// The element is added to the composite element if it doesn't exist, or removed if the value is null.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The Int32 value to set.</param>
  public static void SetValue<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, Int32? value)
    where OpenXmlElementType : OpenXmlLeafElement, new()
  {
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val") ?? typeof(OpenXmlElementType).GetProperty("Value");
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
    if (itemElement != null)
    {
      if (value != null)
        valProperty.SetValue(itemElement, new StringValue(value.ToString()));
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new OpenXmlElementType();
      valProperty.SetValue(itemElement, new StringValue(value.ToString()));
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

}