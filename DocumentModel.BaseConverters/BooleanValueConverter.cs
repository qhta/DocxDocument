namespace DocumentModel.OpenXml;

public static class BooleanValueConverter
{
  #region OnOffValue conversion.
  public static Boolean? GetValue(OnOffValue? element)
  {
    return element?.Value;
  }

  /// <summary>
  /// Sets OnOffValue using false string and true string representation.
  /// </summary>
  /// <param name="value">Boolean value</param>
  /// <param name="falseString">False value string representation (default "0")</param>
  /// <param name="trueString">True value string representation (default "1")</param>
  /// <returns></returns>
  public static OnOffValue? CreateOnOffValue(Boolean? value, string? falseString = null, string? trueString = null)
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
  public static Boolean? GetValue(DXW.OnOffOnlyValues? element)
  {
    if (element == null) return null;
    return element == DXW.OnOffOnlyValues.On;
  }

  public static DXW.OnOffOnlyValues? CreateOnOffOnlyValue(Boolean? value)
  {
    if (value == true) return DXW.OnOffOnlyValues.On;
    if (value == false) return DXW.OnOffOnlyValues.Off;
    return null;
  }
  #endregion

  #region OnOffType conversion.
  public static Boolean? GetValue(DXW.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }


  /// <summary>
  /// Sets OnOffType value in OpenXmlElement using false string and true string representation.
  /// </summary>
  /// <param name="openXmlElement">Composite element to append OnOffType child.</param>
  /// <param name="value">Boolean value</param>
  /// <param name="falseString">False value string representation (default "0")</param>
  /// <param name="trueString">True value string representation (default "1")</param>
  /// <returns></returns>

  public static void SetOnOffType<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value,
    string? falseString = null, string? trueString = null)
    where ElementType : DXW.OnOffType, new()
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ElementType>();
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
          var itemElement = new ElementType();
          if (valStr != null)
            itemElement.SetAttribute(new OpenXmlAttribute
            {
              NamespaceUri = openXmlElement.NamespaceUri,
              LocalName = "val",
              Value = valStr
            });
          openXmlElement.AppendChild(itemElement);
        }
      }
    }
  }

  ///// <summary>
  ///// Sets OnOffType value in OpenXmlElement adding child OnOffType element if true and removing it when false.
  ///// </summary>
  ///// <param name="openXmlElement">Composite element to append OnOffType child.</param>
  ///// <param name="falseString">False value string representation (default "0")</param>
  ///// <param name="trueString">True value string representation (default null)</param>
  ///// <param name="value">Boolean value</param>
  ///// <returns></returns>

  //public static void SetOnOffTypeToggle<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value,
  //  string? falseString = null, string? trueString = null)
  //  where ElementType : DXW.OnOffType, new()
  //{
  //  if (openXmlElement != null)
  //  {
  //    if (value == false)
  //    {
  //      var itemElement = openXmlElement.GetFirstChild<ElementType>();
  //      if (itemElement != null)
  //        itemElement.Remove();
  //    }
  //    if (value != null)
  //    {
  //      if (trueString == null)
  //      {
  //        falseString = "0";
  //        //trueString = "1";
  //      }
  //      string? valStr = (bool)value ? trueString : falseString;
  //      if (valStr != null || value == true)
  //      {
  //        var itemElement = new ElementType();
  //        if (valStr != null)
  //          itemElement.SetAttribute(new OpenXmlAttribute
  //          {
  //            NamespaceUri = openXmlElement.NamespaceUri,
  //            LocalName = "val",
  //            Value = valStr
  //          });
  //        openXmlElement.AppendChild(itemElement);
  //      }
  //    }
  //  }
  //}
  #endregion

  #region Math OnOffType conversion.
  public static Boolean? GetValue(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return GetValue(openXmlElement.Val.Value);
    if (openXmlElement != null) return true;
    return null;
  }

  public static void SetMathOnOffType<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value)
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
  public static Boolean GetValue(DXW.OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value == DXW.OnOffOnlyValues.On;
    return openXmlElement != null;
  }

  public static void SetOnOffOnlyType<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value)
    where ElementType : DXW.OnOffOnlyType, new()
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
        var itemElement = openXmlElement.GetFirstChild<ElementType>();
        if (itemElement == null)
          openXmlElement.AppendChild(new ElementType());
      }
    }
  }
  #endregion

  #region Office2010 Word OnOffValues conversion.
  public static Boolean? GetValue(DX.EnumValue<DXO10W.OnOffValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      switch (openXmlElement.Value)
      {
        case DXO10W.OnOffValues.True:
        case DXO10W.OnOffValues.One:
          return true;
        case DXO10W.OnOffValues.False:
        case DXO10W.OnOffValues.Zero:
          return false;
      }
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
  public static Boolean? GetValue(DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }

  public static void SetO13OnOffType<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value)
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
  public static Boolean? GetValue(DX.EnumValue<DXM.BooleanValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      switch (openXmlElement.Value)
      {
        case DXM.BooleanValues.True:
        case DXM.BooleanValues.On:
        case DXM.BooleanValues.One:
          return true;
        case DXM.BooleanValues.False:
        case DXM.BooleanValues.Off:
        case DXM.BooleanValues.Zero:
          return false;
      }
    }
    return null;
  }

  public static void UpdateOpenXmlElement<ElementType>(ElementType openXmlElement, OnOffValue value)
    where ElementType : DX.OpenXmlElement, new()
  {
    var valueProp = typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    else
      valueProp.SetValue(openXmlElement, value == true);
  }

  public static ElementType CreateOpenXmlElement<ElementType>(OnOffValue value)
  where ElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new ElementType();
    var valueProp = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    valueProp.SetValue(openXmlElement, value);
    return openXmlElement;
  }

  #endregion

  #region TypedOpenXmlLeafTextElement conversion.
  public static bool? GetValue(DX.TypedOpenXmlLeafTextElement? element)
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


  public static OpenXmlElementType? CreateOpenXmlLeafTextElement<OpenXmlElementType>(bool? value)
  where OpenXmlElementType : OpenXmlLeafTextElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
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
  public static Boolean? GetValue(string? str)
  {
    if (str != null)
      return str == "1";
    else
      return null;
  }

  public static string? Create01String(Boolean? value)
  {
    if (value == null) return null;
    return (Boolean)value ? "1" : "0";
  }
  #endregion

  #region Specific Boolean values element conversion.
  public static ElementType CreateWordOpenXmlElement<ElementType>(Boolean value)
  where ElementType : DXO10W.OnOffType, new()
  {
    var openXmlElement = new ElementType();
    var valueProp = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    //if (value==true)
    //  valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One));
    //else
    if (value == false)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.Zero));
    return openXmlElement;
  }

  public static ElementType CreateMathOpenXmlElement<ElementType>(Boolean value)
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
}