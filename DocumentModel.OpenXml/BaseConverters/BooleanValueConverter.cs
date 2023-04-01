using System.Runtime.CompilerServices;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

public static class BooleanValueConverter
{
  #region OnOffValue
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

  #region OnOffOnlyValue
  public static Boolean? GetValue(OnOffOnlyValues? element)
  {
    if (element == null) return null;
    return element == OnOffOnlyValues.On;
  }

  public static Boolean CmpValue(OnOffOnlyValues? element, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (element!=null && value != null)
    {
      if ((element == OnOffOnlyValues.On) && value==true) return true;
      if ((element == OnOffOnlyValues.Off) && value==false) return true;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, propName ?? element?.GetType().Name, element, value);
    return false;
  }

  public static OnOffOnlyValues? CreateOnOffOnlyValue(Boolean? value)
  {
    if (value == true) return OnOffOnlyValues.On;
    if (value == false) return OnOffOnlyValues.Off;
    return null;
  }
  #endregion

  #region Convert OnOffType
  public static Boolean? GetValue(OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }

  public static Boolean CmpValue(OnOffType? openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
    where ElementType : OnOffType, new()
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

  #region Convert OnOffOnlyType
  public static Boolean GetValue(OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value == DXW.OnOffOnlyValues.On;
    return openXmlElement != null;
  }

  public static Boolean CmpValue(OnOffOnlyType? openXmlElement, Boolean? value, DiffList? diffs, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value != null && value != null)
    {
      if (openXmlElement.Val.Value == OnOffOnlyValues.On && value == true)
        return true;
      if (openXmlElement.Val.Value == OnOffOnlyValues.Off && value == false)
        return true;
      diffs?.Add(objName, propName ?? openXmlElement.GetType().Name, openXmlElement.Val.Value == OnOffOnlyValues.On, value);
      return false;
    }
    if (openXmlElement?.Val?.Value == null && value == null)
      return true;
    if (openXmlElement != null && value == true)
      return true;
    if (openXmlElement == null && value == false)
      return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement?.Val?.Value == OnOffOnlyValues.On, value);
    return false;
  }

  public static void SetOnOffOnlyType<ElementType>(OpenXmlCompositeElement openXmlElement, Boolean? value)
    where ElementType : OnOffOnlyType, new()
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
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  #endregion


  public static bool? GetValue(DX.TypedOpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      var text = (string)element.Text.ToLower();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Boolean? value)
  where OpenXmlElementType : OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Normal");
      if (valProperty != null)
        valProperty.SetValue(element, (bool)value ? OnOffOnlyValues.On : OnOffOnlyValues.Off);
      else if (element is DX.TypedOpenXmlLeafTextElement textElement)
        textElement.Text = (bool)value ? "true" : "false";
      return element;
    }
    return null;
  }
}