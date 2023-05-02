using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml;

public static class BooleanValueConverter
{
  #region OnOffValue conversion.
  public static Boolean? GetValue(OnOffValue? element)
  {
    return element?.Value;
  }

  public static Boolean CmpValue(OnOffValue? element, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (element?.Value == value) return true;
    diffs?.Add(objName, propName ?? element?.GetType().Name, element?.Value, value);
    return false;
  }

  public static OnOffValue? CreateOnOffValue(Boolean? value)
  {
    if (value == null) return null;
    return new OnOffValue { Value = (Boolean)value };
  }
  #endregion

  #region OnOffOnlyValue conversion.
  public static Boolean? GetValue(DXW.OnOffOnlyValues? element)
  {
    if (element == null) return null;
    return element == DXW.OnOffOnlyValues.On;
  }

  public static Boolean CmpValue(DXW.OnOffOnlyValues? element, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (element != null && value != null)
    {
      if ((element == DXW.OnOffOnlyValues.On) && value == true) return true;
      if ((element == DXW.OnOffOnlyValues.Off) && value == false) return true;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, propName ?? element?.GetType().Name, element, value);
    return false;
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

  public static Boolean CmpValue(DXW.OnOffType? openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value != null && value != null)
    {
      if (openXmlElement.Val.Value == true && value == true)
        return true;
      if (openXmlElement.Val.Value == false && value == false)
        return true;
      diffs?.Add(objName, propName ?? openXmlElement.GetType().Name, openXmlElement.Val.Value, value);
      return false;
    }
    if (openXmlElement?.Val?.Value == null && value == null)
      return true;
    if (openXmlElement != null && value == true)
      return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement?.Val?.Value, value);
    return false;
  }

  public static void SetOnOffType<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value)
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
      if (value == true)
      {
        var itemElement = new ElementType { Val = value };
        openXmlElement.AddChild(itemElement);
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

  public static Boolean CmpValue(DXW.OnOffOnlyType? openXmlElement, Boolean? value, DiffList? diffs, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value != null && value != null)
    {
      if (openXmlElement.Val.Value == DXW.OnOffOnlyValues.On && value == true)
        return true;
      if (openXmlElement.Val.Value == DXW.OnOffOnlyValues.Off && value == false)
        return true;
      diffs?.Add(objName, propName ?? openXmlElement.GetType().Name, openXmlElement.Val.Value == DXW.OnOffOnlyValues.On, value);
      return false;
    }
    if (openXmlElement?.Val?.Value == null && value == null)
      return true;
    if (openXmlElement != null && value == true)
      return true;
    if (openXmlElement == null && value == false)
      return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement?.Val?.Value == DXW.OnOffOnlyValues.On, value);
    return false;
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
          openXmlElement.AddChild(new ElementType());
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

  public static Boolean CmpValue(DX.EnumValue<DXO10W.OnOffValues>? openXmlElement, Boolean? value, DiffList? diffs, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Value != null && value != null)
    {
      switch (openXmlElement.Value)
      {
        case DXO10W.OnOffValues.True:
        case DXO10W.OnOffValues.One:
          return value == true;
        case DXO10W.OnOffValues.False:
        case DXO10W.OnOffValues.Zero:
          return value == false;
      }
    }
    if (openXmlElement?.Value == null && value == null)
      return true;
    if (openXmlElement != null && value == true)
      return true;
    if (openXmlElement == null && value == false)
      return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement?.Value, value);
    return false;
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

  public static Boolean CmpValue(DXO13W.OnOffType? openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value != null && value != null)
    {
      if (openXmlElement.Val.Value == true && value == true)
        return true;
      if (openXmlElement.Val.Value == false && value == false)
        return true;
      diffs?.Add(objName, propName ?? openXmlElement.GetType().Name, openXmlElement.Val.Value, value);
      return false;
    }
    if (openXmlElement?.Val?.Value == null && value == null)
      return true;
    if (openXmlElement != null && value == true)
      return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement?.Val?.Value, value);
    return false;
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
        openXmlElement.AddChild(itemElement);
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

  public static Boolean CmpValue(DX.EnumValue<DXM.BooleanValues>? openXmlElement, Boolean? value, DiffList? diffs, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Value != null && value != null)
    {
      switch (openXmlElement.Value)
      {
        case DXM.BooleanValues.True:
        case DXM.BooleanValues.On:
        case DXM.BooleanValues.One:
          return value == true;
        case DXM.BooleanValues.False:
        case DXM.BooleanValues.Off:
        case DXM.BooleanValues.Zero:
          return value == false;
      }
    }
    if (openXmlElement?.Value == null && value == null)
      return true;
    if (openXmlElement != null && value == true)
      return true;
    if (openXmlElement == null && value == false)
      return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement?.Value, value);
    return false;
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

  public static bool CmpValue(DX.TypedOpenXmlLeafTextElement element, bool? value, DiffList? diffs, string? objName, string? propName = null)
  {
    if (GetValue(element) == value)
      return true;
    diffs?.Add(objName, propName ?? element.GetType().ToString(), element.Text, value);
    return false;
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


  public static ElementType CreateMathOpenXmlElement<ElementType>(Boolean value)
  where ElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new ElementType();
    var valueProp = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    if (value==true)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One));
    else
    if (value==false)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.Zero));
    return openXmlElement;
  }
}