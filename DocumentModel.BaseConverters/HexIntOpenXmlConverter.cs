namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for HexInt values (hexadecimal integers) in Open XML.
/// </summary>
public static class HexIntOpenXmlConverter
{
  #region HexInt get methods

  /// <summary>
  /// Retrieves a HexInt value from a child element within an OpenXmlCompositeElement.
  /// Checks for LongHexNumberType elements or elements with a "Val" property compatible with hex strings.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>A HexInt value, or null if the element or value is not found.</returns>
  public static HexInt? GetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement)
    where OpenXmlElementType: DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element is DXW.LongHexNumberType longHexNumberType)
      {
        if (longHexNumberType.Val?.Value != null)
          return new HexInt(longHexNumberType.Val.Value!);
      }
      else if (element != null)
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
  /// Sets a HexInt value on a child element within an OpenXmlCompositeElement.
  /// Creates the element if it doesn't exist, or removes it if the value is null.
  /// Supports LongHexNumberType, HexBinaryValue, and StringValue properties.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The HexInt value to set.</param>
  /// <exception cref="InvalidOperationException">Thrown if the "Val" property type is unsupported.</exception>
  public static void SetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, HexInt? value)
    where OpenXmlElementType: DX.OpenXmlElement
  {
    if (value is not null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor([]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        element = (OpenXmlElementType)constructor.Invoke([]);
        openXmlElement.AppendChild(element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DXW.LongHexNumberType))
      {
        DXW.LongHexNumberType? propElement = (DXW.LongHexNumberType?)valType.GetConstructor([])?.Invoke([]);
        Debug.Assert(propElement != null, $"\"{valType}\" type must have a parameterless constructor");
        propElement.Val = new DX.HexBinaryValue(value.ToString());
        valProperty.SetValue(element, propElement);
      }
      else if (valType == typeof(DX.HexBinaryValue))
        valProperty.SetValue(element, new DX.HexBinaryValue(value.ToString()));
      else if (valType == typeof(DX.StringValue))
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
  /// Retrieves a HexInt value from a HexBinaryValue element.
  /// </summary>
  /// <param name="element">The HexBinaryValue element.</param>
  /// <returns>A HexInt value, or null if element or value is null.</returns>
  public static HexInt? GetValue(this DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;

    return null;
  }

  /// <summary>
  /// Retrieves a HexInt value from an Int32Value element (interpreting integer as hex if applicable, commonly used for indexed colors).
  /// Note: This method currently returns the string representation of the integer value.
  /// </summary>
  /// <param name="element">The Int32Value element.</param>
  /// <returns>A HexInt value, or null if element or value is null.</returns>
  public static HexInt? GetValue(this DX.Int32Value? element)
  {
    if (element?.Value != null)
      return element.Value;

    return null;
  }

  /// <summary>
  /// Retrieves a HexInt value from a UInt32Value element.
  /// Note: This method currently returns the string representation of the integer value.
  /// </summary>
  /// <param name="element">The UInt32Value element.</param>
  /// <returns>A HexInt value, or null if element or value is null.</returns>
  public static HexInt? GetValue(this DX.UInt32Value? element)
  {
    if (element?.Value != null)
      return element.Value;

    return null;
  }

  /// <summary>
  /// Retrieves a HexInt value from a LongHexNumberType element.
  /// </summary>
  /// <param name="element">The LongHexNumberType element.</param>
  /// <returns>A HexInt value, or null if element or value is null.</returns>
  public static HexInt? GetValue(this DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;

    return null;
  }

  /// <summary>
  /// Retrieves a HexInt value from a StringValue element.
  /// </summary>
  /// <param name="element">The StringValue element.</param>
  /// <returns>A HexInt value, or null if element or value is null.</returns>
  public static HexInt? GetValue(this DX.StringValue? element)
  {
    if (element?.Value != null)
      return element.Value;

    return null;
  }

  /// <summary>
  /// Retrieves a HexInt value from an OpenXmlLeafElement that has a property of HexBinaryValue type.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlLeafElement.</param>
  /// <returns>A HexInt value, or null if property not found or value is null.</returns>
  public static HexInt? GetValue(this DX.OpenXmlLeafElement? openXmlElement)
  {
    var valProperty = openXmlElement?.GetType().GetProperties().FirstOrDefault(item => item.PropertyType == typeof(DX.HexBinaryValue));
    if (valProperty != null)
    {
      var value = valProperty.GetValue(openXmlElement);
      if (value is string valStr)
        return valStr;
      if (value is DX.HexBinaryValue hexBinaryValue && hexBinaryValue.Value != null)
        return hexBinaryValue.Value;
    }
    return null;
  }

  /// <summary>
  /// Creates a HexBinaryValue from a HexInt value.
  /// </summary>
  /// <param name="value">The HexInt value.</param>
  /// <returns>A new HexBinaryValue, or null if the input value is null.</returns>
  public static DX.HexBinaryValue? CreateHexBinaryValue(this HexInt? value)
  {
    if (value is null) return null;

    return new DX.HexBinaryValue(value.ToString());
  }

  /// <summary>
  /// Creates a StringValue from a HexInt value.
  /// </summary>
  /// <param name="value">The HexInt value.</param>
  /// <returns>A new StringValue, or null if the input value is null.</returns>
  public static DX.StringValue? CreateStringValue(this HexInt? value)
  {
    if (value == null) return null;

    return new DX.StringValue { Value = value.ToString() };
  }

  /// <summary>
  /// Creates a specific HexBinaryType element from a HexInt value.
  /// </summary>
  /// <typeparam name="HexBinaryType">The type of the element to create (e.g., LongHexNumberType).</typeparam>
  /// <param name="value">The HexInt value.</param>
  /// <returns>A new instance of the element type, or null if the input value is null.</returns>
  public static HexBinaryType? CreateValue<HexBinaryType>(this HexInt? value)
    where HexBinaryType: DXW.LongHexNumberType, new()
  {
    if (value is null) return null;

    var element = new HexBinaryType();
    element.Val = new DX.HexBinaryValue(value.ToString());
    return element;
  }

  /// <summary>
  /// Creates a generic OpenXml element and sets its HexBinaryValue property from a HexInt value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXml element to create.</typeparam>
  /// <param name="value">The HexInt value.</param>
  /// <returns>A new instance of the element type, or a default instance if value is null.</returns>
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(this HexInt? value)
    where OpenXmlElementType: DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value.ToString());
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item => item.PropertyType == typeof(DX.HexBinaryValue));
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }

  #endregion

  #region OpenXmlLeafElement with Val property conversion methods

  /// <summary>
  /// Retrieves a HexInt value from a specific OpenXmlLeafElement instance using its "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlLeafElement.</typeparam>
  /// <param name="openXmlElement">The element instance.</param>
  /// <param name="propName">The property name to read from (default is "Val").</param>
  /// <returns>A HexInt value, or null if not found.</returns>
  public static HexInt? GetHexIntVal<OpenXmlElementType>(this DX.OpenXmlLeafElement? openXmlElement, string? propName = null)
    where OpenXmlElementType: DX.OpenXmlLeafElement
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
          if (value is not null)
          {
            if (value is string str)
              return str;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a HexInt value on a specific OpenXmlLeafElement instance using its "Val" property.
  /// Adds the child element if needed, or removes it if the value is null.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent element.</param>
  /// <param name="value">The string value to set.</param>
  /// <param name="propName">The property name to set (default is "Val").</param>
  public static void SetHexIntVal<OpenXmlElementType>(this DX.OpenXmlLeafElement openXmlElement, String? value, string? propName = null)
    where OpenXmlElementType: DX.OpenXmlLeafElement, new()
  {
    if (propName == null)
      propName = "Val";
    var valProperty = typeof(OpenXmlElementType).GetProperty(propName);
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
    if (itemElement != null)
    {
      if (value is not null)
        valProperty.SetValue(itemElement, new DX.HexBinaryValue(value));
      else
        itemElement.Remove();
    }
    else if (value is not null)
    {
      itemElement = new OpenXmlElementType();
      valProperty.SetValue(itemElement, new DX.StringValue(value));
      openXmlElement.AppendChild(itemElement);
    }
  }

  #endregion

  #region OpenXmlLeafElement with Val property conversion methods

  /// <summary>
  /// Retrieves a HexInt value from a specific child element of a composite element.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="propName">The property name to read from (default is "Val").</param>
  /// <returns>A HexInt value, or null if not found.</returns>
  public static HexInt? GetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement, string? propName)
    where OpenXmlElementType: DX.OpenXmlLeafElement
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
          if (value is not null)
          {
            if (value is string str)
              return str;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a HexInt value on a specific child element of a composite element.
  /// Adds the child element if needed, or removes it if the value is null.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The string value to set.</param>
  /// <param name="propName">The property name to set (default is "Val").</param>
  public static void SetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, String? value, string? propName = null)
    where OpenXmlElementType: DX.OpenXmlLeafElement, new()
  {
    if (propName == null)
      propName = "Val";
    var valProperty = typeof(OpenXmlElementType).GetProperty(propName);
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
    if (itemElement != null)
    {
      if (value is not null)
        valProperty.SetValue(itemElement, new DX.HexBinaryValue(value));
      else
        itemElement.Remove();
    }
    else if (value is not null)
    {
      itemElement = new OpenXmlElementType();
      valProperty.SetValue(itemElement, new DX.StringValue(value));
      openXmlElement.AppendChild(itemElement);
    }
  }

  #endregion

  /// <summary>
  /// Sets a HexInt value in the specified OpenXmlCompositeElement either by updating an existing child or adding a new one.
  /// </summary>
  /// <typeparam name="OpenElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The HexInt value to set. If null, the child element is removed.</param>
  public static void SetValue<OpenElementType>(this DX.OpenXmlCompositeElement openXmlElement, HexInt? value)
    where OpenElementType: DX.OpenXmlElement, new()
  {
    var valProperty = typeof(OpenElementType).GetProperty("Val") ?? typeof(OpenElementType).GetProperty("Value");
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<OpenElementType>();
    if (itemElement != null)
    {
      if (value is not null)
        valProperty.SetValue(itemElement, HexIntOpenXmlConverter.CreateHexBinaryValue((HexInt)value));
      else
        itemElement.Remove();
    }
    else if (value is not null)
    {
      itemElement = new OpenElementType();
      valProperty.SetValue(itemElement, new DX.HexBinaryValue(value.ToString()));
      openXmlElement.AppendChild(itemElement);
    }
  }

  #region Generic conversion methods

  /// <summary>
  /// Creates an Open XML element of the specified type from a HexInt value.
  /// </summary>
  /// <param name="hexIntVal">The HexInt value to convert.</param>
  /// <param name="conversionType">The target Open XML element type.</param>
  /// <returns>The created Open XML element, or null if the input is null.</returns>
  /// <exception cref="InvalidOperationException"></exception>
  public static object? ConvertToOpenXml(HexInt? hexIntVal, Type conversionType)
  {
    if (hexIntVal == null) return null;

    if (conversionType == typeof(DX.HexBinaryValue))
    {
      return new DX.HexBinaryValue(hexIntVal.ToString());
    }
    throw new NotSupportedException($"Conversion from HexInt to {conversionType} is not supported");
  }

  /// <summary>
  /// Converts an Open XML value to its string representation, if supported.
  /// </summary>
  /// <param name="value">The Open XML value to convert. This can be an instance of StringValue, DXW.StringType, DXW.String255Type,
  /// DXW.String253Type, OpenXmlLeafTextElement, or OpenXmlLeafElement. May be null.</param>
  /// <returns>A string representation of the specified Open XML value, or null if <paramref name="value"/> is null.</returns>
  /// <exception cref="NotSupportedException">Thrown if <paramref name="value"/> is not a supported Open XML type.</exception>
  public static HexInt? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (value is DX.HexBinaryValue hexBinaryValue)
    {
      return new HexInt(hexBinaryValue.Value!);
    }
    throw new NotSupportedException($"Conversion from type {sourceType} to HexInt is not supported.");
  }

  #endregion
}