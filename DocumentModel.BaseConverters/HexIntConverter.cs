namespace DocumentModel.OpenXml;

public static class HexIntConverter
{

  #region HexInt get/set methods

  /// <summary>
  /// Gets a HexInt value from OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property.
  /// This property may be of DXW.LongHexNumberType or any other type which has a string value expressing hexadecimal int.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static HexInt? GetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element is DXW.LongHexNumberType longHexNumberType)
      {
        if (longHexNumberType.Val?.Value != null)
          return new HexInt(longHexNumberType.Val.Value!);
      }
      else
      if (element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is string str)
          {
            return new HexInt(str);
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets the specified HexInt value to the OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property
  /// This property may be of DXW.LongHexNumberType or HexBinaryValue or StringValue.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void SetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, HexInt? value) where OpenXmlElementType : DX.OpenXmlElement
  {
    if (value != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DXW.LongHexNumberType))
      {
        DXW.LongHexNumberType? propElement = (DXW.LongHexNumberType?)valType.GetConstructor(new Type[0])?.Invoke(new object[0]);
        Debug.Assert(propElement != null, $"\"{valType}\" type must have a parameterless constructor");
        propElement.Val = new DX.HexBinaryValue(value.ToString());
        valProperty.SetValue(element, propElement);
      }
      else
      if (valType == typeof(DX.HexBinaryValue))
        valProperty.SetValue(element, new DX.HexBinaryValue(value.ToString()));
      else
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(element, new DX.StringValue(value.ToString()));
      else
        throw new InvalidOperationException($"\"Value\" property of type {valType} unsupported");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region HexBinaryValue get/set methods.

  /// <summary>
  /// Gets a HexInt value from the specified OpenXml HexBinaryValue.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static HexInt? GetValue(this DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  /// <summary>
  /// Sets a HexInt value in the specified OpenXmlCompositeElement containing OpenXmlElementType element with a "Val" property.
  /// </summary>
  /// <typeparam name="OpenElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetValue<OpenElementType>(this OpenXmlCompositeElement openXmlElement, HexInt? value)
    where OpenElementType : OpenXmlElement, new()
  {
    var valProperty = typeof(OpenElementType).GetProperty("Val") ?? typeof(OpenElementType).GetProperty("Value");
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<OpenElementType>();
    if (itemElement != null)
    {
      if (value != null)
        valProperty.SetValue(itemElement, HexIntConverter.CreateHexBinaryValue(value));
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new OpenElementType();
      valProperty.SetValue(itemElement, new HexBinaryValue(value.ToString()));
      openXmlElement.AppendChild(itemElement);
    }
  }

  /// <summary>
  /// Gets a HexInt value from the specified OpenXml LongHexNumberType.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static HexInt? GetValue(this DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

  /// <summary>
  /// Gets a HexInt value from the specified OpenXml TypedOpenXmlLeafElement
  /// which has a property of HexBinaryValue type.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static HexInt? GetValue(this DX.TypedOpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperties().FirstOrDefault(item => item.PropertyType == typeof(HexBinaryValue));
    if (valProperty != null)
    {
      var value = valProperty.GetValue(openXmlElement);
      if (value is string valStr)
        return valStr;
      if (value is HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return hexBinaryValue.Value;
    }
    return null;
  }

  /// <summary>
  /// Creates a HexBinaryValue from the specified HexInt value.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DX.HexBinaryValue? CreateHexBinaryValue(this HexInt? value)
  {
    if (value != null) return new DX.HexBinaryValue(value.ToString());
    return null;
  }

  /// <summary>
  /// Creates a StringValue from the specified HexInt value.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static StringValue? CreateStringValue(this HexInt? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }


  /// <summary>
  /// Creates a specified HexBinaryType value from the specified HexInt value.
  /// </summary>
  /// <typeparam name="HexBinaryType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static HexBinaryType? CreateValue<HexBinaryType>(this HexInt? value)
    where HexBinaryType : DXW.LongHexNumberType, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Val = new DX.HexBinaryValue(value.ToString());
      return element;
    }
    return null;
  }

  /// <summary>
  /// Creates a specified OpenXmlElementType value from the specified HexInt value
  /// and sets its first property which is of HexBinaryValue type.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(this HexInt? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value.ToString());
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item => item.PropertyType == typeof(HexBinaryValue));
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
  #endregion
}