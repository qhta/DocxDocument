namespace DocumentModel.OpenXml;

public static class BooleanValueConverter
{
  #region OnOffValue conversion.

  /// <summary>
  /// Gets a boolean value from the specified OnOffValue element.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static Boolean? GetValue(this OnOffValue? element)
  {
    return element?.Value;
  }

  /// <summary>
  /// Sets OnOffValue using "false" string and "true" string representation.
  /// </summary>
  /// <param name="value">Boolean value</param>
  /// <param name="falseString">False value string representation (default "0")</param>
  /// <param name="trueString">True value string representation (default "1")</param>
  /// <returns></returns>
  public static OnOffValue? CreateOnOffValue(this Boolean? value, string? falseString = null, string? trueString = null)
  {
    if (value == null) return null;
    if (trueString == null)
    {
      falseString = "0";
      trueString = "1";
    }
    var val = (Boolean)value ? trueString : falseString;
    if (val == null)
      return null;
    return new OnOffValue { InnerText = val };
  }
  #endregion

  #region OnOffOnlyValue conversion.
  /// <summary>
  /// Gets a boolean value from the specified OnOffOnlyValues element.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean? GetValue(this DXW.OnOffOnlyValues? openXmlElement)
  {
    if (openXmlElement == null) return null;
    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an OnOffOnlyValues element from the specified boolean value.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DXW.OnOffOnlyValues? CreateOnOffOnlyValue(this Boolean? value)
  {
    if (value == true) return DXW.OnOffOnlyValues.On;
    if (value == false) return DXW.OnOffOnlyValues.Off;
    return null;
  }
  #endregion

  #region OnOffType conversion.
  /// <summary>
  /// Gets a boolean value from the specified OnOffType element.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean? GetValue(this DXW.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }


  /// <summary>
  /// Sets an OnOffType value of OpenXmlElement using false string and true string representation
  /// and adds it the the OpenXmlCompositeElement.
  /// </summary>
  /// <param name="openXmlElement">Composite element to append OnOffType child.</param>
  /// <param name="value">Boolean value</param>
  /// <param name="falseString">False value string representation (default "0")</param>
  /// <param name="trueString">True value string representation (default "1")</param>
  /// <returns></returns>

  public static void SetOnOffType<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value,
    string? falseString = null, string? trueString = null)
    where OpenXmlElementType : DXW.OnOffType, new()
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value != null)
      {
        if (trueString == null && falseString == null)
        {
          falseString = "0";
          trueString = "1";
        }
        string? valStr = (bool)value ? trueString : falseString;
        if (valStr != null || value == true)
        {
          var itemElement = new OpenXmlElementType();
          if (valStr != null)
            itemElement.SetAttribute(new OpenXmlAttribute("val", openXmlElement.NamespaceUri, valStr));
          openXmlElement.AppendChild(itemElement);
        }
      }
    }
  }

  #endregion

  #region Math OnOffType conversion.
  /// <summary>
  /// Gets a boolean value from the specified Math OnOffType element.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean? GetValue(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return GetValue(openXmlElement.Val.Value);
    if (openXmlElement != null) return true;
    return null;
  }

  /// <summary>
  /// Sets Math OnOffType value of OpenXmlElement using false string and true string representation
  /// and adds it the the OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="ElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetMathOnOffType<ElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value)
    where ElementType : DXM.OnOffType, new()
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ElementType>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ElementType();
        openXmlElement.AppendChild(itemElement);
      }
    }
  }
  #endregion

  #region OnOffOnlyType conversion.

  /// <summary>
  /// Gets a boolean value from the specified OnOffOnlyType element.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean GetValue(this DXW.OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value == DXW.OnOffOnlyValues.On;
    return openXmlElement != null;
  }

  /// <summary>
  /// Sets an OnOffOnlyType value of OpenXmlElement using false string and true string representation
  /// and adds it the the OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetOnOffOnlyType<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value)
    where OpenXmlElementType : DXW.OnOffOnlyType, new()
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
        if (itemElement == null)
          openXmlElement.AppendChild(new OpenXmlElementType());
      }
    }
  }
  #endregion

  #region Office2010 Word OnOffValues conversion.
  /// <summary>
  /// Gets a boolean value from the specified Word13 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean? GetValue(this DX.EnumValue<DXO10W.OnOffValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      var value = openXmlElement.Value;
      if (value == DXO10W.OnOffValues.True
        || value == DXO10W.OnOffValues.One)
        return true;
      if (value == DXO10W.OnOffValues.False
        || value == DXO10W.OnOffValues.Zero)
        return false;
    }
    return null;
  }


  //public static void UpdateOpenXmlElement<ElementType>(ElementType openXmlElement, Boolean value)
  //  where ElementType : DX.OpenXmlElement, new()
  //{
  //  var valueProp = typeof(ElementType).GetProperty("Value");
  //  if (valueProp != null)
  //    valueProp.SetValue(openXmlElement, value == true);
  //  else
  //    throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
  //}

  //public static ElementType CreateOpenXmlElement<ElementType>(Boolean value)
  //where ElementType : DX.OpenXmlElement, new()
  //{
  //  var openXmlElement = new ElementType();
  //  var valueProp = typeof(ElementType).GetProperty("Value");
  //  if (valueProp != null)
  //    valueProp.SetValue(openXmlElement, value == true);
  //  else
  //    throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
  //  return openXmlElement;
  //}
  #endregion

  #region Office2013 Word OnOffType conversion.
  /// <summary>
  /// Gets a boolean value from the specified Word13 OnOffType.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean? GetValue(this DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }

  /// <summary>
  /// Sets an Word13 OnOffType value form the specified boolean value.
  /// </summary>
  /// <typeparam name="ElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetO13OnOffType<ElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value)
    where ElementType : DXO13W.OnOffType, new()
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ElementType>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ElementType { Val = value };
        openXmlElement.AppendChild(itemElement);
      }
    }
  }
  #endregion

  #region Math BooleanValues conversion.
  /// <summary>
  /// Gets a boolean value from the specified EnumValue of BooleanValues.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Boolean? GetValue(this DX.EnumValue<DXM.BooleanValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      var value = openXmlElement.Value;
      if (value == DXM.BooleanValues.True
        || value == DXM.BooleanValues.On
        || value == DXM.BooleanValues.One)
        return true;
      if (value == DXM.BooleanValues.False
        || value == DXM.BooleanValues.Off
        || value == DXM.BooleanValues.Zero)
        return false;
    }
    return null;
  }

  /// <summary>
  /// Updates and OpenXmlElement with the specified OnOffValue.
  /// </summary>
  /// <typeparam name="ElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidProgramException"></exception>
  public static void UpdateOpenXmlElement<ElementType>(this ElementType openXmlElement, OnOffValue value)
    where ElementType : DX.OpenXmlElement, new()
  {
    var valueProp = typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    else
      valueProp.SetValue(openXmlElement, value == true);
  }

  /// <summary>
  /// Creates an OpenXmlElement from the specified OnOffValue and sets its "Val" or "Value" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="InvalidProgramException"></exception>
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(this OnOffValue value)
  where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    var valueProp = typeof(OpenXmlElementType).GetProperty("Val") ?? typeof(OpenXmlElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(OpenXmlElementType)}");
    valueProp.SetValue(openXmlElement, value);
    return openXmlElement;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.
  /// <summary>
  /// Gets a boolean value from the specified TypedOpenXmlLeaf element.
  /// </summary>
  /// <param name="element"></param>
  /// <returns></returns>
  public static bool? GetBoolTextVal(this DX.OpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      var text = element.Text.ToLower();
      switch (text)
      {
        case "true": return true;
        case "false": return false;
        case "1": return true;
        case "0": return false;
      }
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElementType from the specified boolean value. 
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static OpenXmlLeafTextElementType? CreateOpenXmlLeafTextElement<OpenXmlLeafTextElementType>(this bool? value)
  where OpenXmlLeafTextElementType : OpenXmlLeafTextElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlLeafTextElementType();
      if (value == true)
      {
        element.Text = "1";
      }
      else
      if (value == false)
      {
        element.Text = "0";
      }
      return element;
    }
    return null;
  }
  #endregion

  #region String value conversion.
  /// <summary>
  /// Gets a boolean value from the specified "0"/"1" string.
  /// </summary>
  /// <param name="str"></param>
  /// <returns></returns>
  public static Boolean? GetBoolValue(this string? str)
  {
    if (str != null)
      return str == "1";
    else
      return null;
  }

  /// <summary>
  /// Creates a "0"/"1" string from the specified boolean value. 
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static string? Create01String(this Boolean? value)
  {
    if (value == null) return null;
    return (Boolean)value ? "1" : "0";
  }
  #endregion

  #region Specific Boolean values element conversion.
  /// <summary>
  /// Creates a Word10 OnOffType element from the specified boolean value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="InvalidProgramException"></exception>
  public static OpenXmlElementType CreateWordOpenXmlElement<OpenXmlElementType>(this Boolean value)
  where OpenXmlElementType : DXO10W.OnOffType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    var valueProp = typeof(OpenXmlElementType).GetProperty("Val") ?? typeof(OpenXmlElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(OpenXmlElementType)}");
    //if (value==true)
    //  valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One));
    //else
    if (value == false)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.Zero));
    return openXmlElement;
  }

  /// <summary>
  /// Creates a OpenXmlElement OnOffType element from the specified boolean value.
  /// </summary>
  /// <typeparam name="ElementType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="InvalidProgramException"></exception>
  public static ElementType CreateMathOpenXmlElement<ElementType>(this Boolean value)
  where ElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new ElementType();
    var valueProp = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    //if (value==true)
    //  valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One));
    //else
    if (value == false)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.Zero));
    return openXmlElement;
  }
  #endregion

  #region Boolean get/set methods
  /// <summary>
  /// Gets a boolean value from the specified OpenXml CompositeElement containing specified OnOffType element.
  /// </summary>
  /// <typeparam name="OpenXmlElement"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  /// <exception cref="InvalidDataException"></exception>
  public static bool? GetBoolVal<OpenXmlElement>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElement : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var element = openXmlElement.Elements<OpenXmlElement>().FirstOrDefault();
      if (element != null)
      {
        if (element is DXW.OnOffType onOffType)
        {
          if (onOffType.Val?.HasValue == true)
            return onOffType.Val.Value;
          return true;
        }
        else
        if (element is DXO13W.OnOffType onOffType13)
        {
          if (onOffType13.Val?.HasValue == true)
            return onOffType13.Val.Value;
          return true;
        }
        else
        if (element is DXM.OnOffType onOffTypeM)
        {
          if (onOffTypeM.Val?.HasValue == true)
          {
            if (
              onOffTypeM.Val.Value == DXM.BooleanValues.One ||
              onOffTypeM.Val.Value == DXM.BooleanValues.True ||
              onOffTypeM.Val.Value == DXM.BooleanValues.On)
              return true;
            else
            if (
              onOffTypeM.Val.Value == DXM.BooleanValues.Zero ||
              onOffTypeM.Val.Value == DXM.BooleanValues.False ||
              onOffTypeM.Val.Value == DXM.BooleanValues.Off)
              return false;
            else throw new InvalidDataException($"Invalid Math.OnOffType Val property");
          }
          return true;
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a boolean value in the specified OpenXml CompositeElement containing specified OnOffType element.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetBoolVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, bool? value) where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element == null)
      {
        element = new OpenXmlElementType();
        openXmlElement.AppendChild(element);
      }
      if (element is DXW.OnOffType onOffType)
        onOffType.Val = value;
      else
      if (element is DXO13W.OnOffType onOffType13)
        onOffType13.Val = value;
      else
      if (element is DXM.OnOffType onOffTypeM)
      {
        if (value == true)
          onOffTypeM.Val = DXM.BooleanValues.One;
        else
        if (value == false)
          onOffTypeM.Val = DXM.BooleanValues.Zero;
      }
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Gets a "true" value if the OpenXmlElementType in OpenXml CompositeElement exists,
  /// and a "false" value otherwise.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static bool? GetTrueIfExists<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DXW.EmptyType
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      return _element != null;
    }
    return null;
  }

  /// <summary>
  /// Adds an OpenXmlElementType element in OpenXml CompositeElement when boolean value is true,
  /// otherwise removes it. 
  /// </summary>
  /// <typeparam name="ElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetExistsIfTrue<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, bool? value) where ElementType : DXW.EmptyType, new()
  {
    if (value != null)
    {
      if (value == true)
      {
        if (openXmlElement.Elements<ElementType>().FirstOrDefault() == null)
          openXmlElement.AppendChild(new ElementType());
      }
      else
      {
        var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
        if (_element != null)
          _element.Remove();
      }
    }
  }
  #endregion

}