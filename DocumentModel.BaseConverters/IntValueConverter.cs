namespace DocumentModel.OpenXml;

/// <summary>
/// Converter of Int values
/// </summary>
public static class IntValueConverter
{
  #region CompositeElement Int get/set methods

  /// <summary>
  /// Gets an int value from OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property.
  /// Returned value IntegerType is specified as a type parameter.
  /// The read property name can be explicitily specified.
  /// </summary>
  /// <typeparam name="IntegerType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="propName"></param>
  /// <returns></returns>
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
  /// Sets the int value in OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property.
  /// Returned value IntegerType is specified as a type parameter.
  /// The written property name can be explicitily specified.
  /// </summary>
  /// <typeparam name="IntegerType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <param name="propName"></param>
  /// <exception cref="InvalidCastException"></exception>
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
  /// Converts HpsMeasureType to Int32.
  /// </summary>
  /// <param name="hpsValue">HpsMeasureType to Convert</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
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
  /// Creates a specific OpenXml HpsMeasureType element based on Int32 value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">Can be any OpenXmlElement type</typeparam>
  /// <param name="value">value to convert</param>
  /// <returns>Newly created OpenXmlElement (or <c>null</c> if conversion is impossible</returns>
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
  /// Converts IntegerValue to Int32.
  /// </summary>
  /// <param name="integerValue">IntegerValue to convert</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static Int32? GetValue(IntegerValue? integerValue)
  {
    if (integerValue?.Value != null)
    {
      return (Int32)integerValue.Value;
    }
    return null;
  }

  public static IntegerValue? CreateIntegerValue(Int32? value)
  {
    if (value == null) return null;
    return new IntegerValue { Value = (Int32)value };
  }
  #endregion

  #region StringValue conversion.
  /// <summary>
  /// Converts StringValue to Int32 value.
  /// </summary>
  /// <param name="stringValue">StringValue to Convert</param>
  /// <returns>Int32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
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
  /// Creates a StringValue from Int32 value.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static StringValue? CreateStringValue(Int32? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }

  /// <summary>
  /// Sets the specified Int32 value to the OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property
  /// which is of StringValue type.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetValue<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, Int32? value)
    where OpenXmlElementType : TypedOpenXmlLeafElement, new()
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