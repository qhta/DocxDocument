using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

public static class BooleanValueConverter
{
  //public static Boolean? GetValue(OnOffOnlyValues? element)
  //{
  //  if (element != null)
  //    return element == OnOffOnlyValues.On;
  //  return null;
  //}

  //public static Boolean CmpValue(OnOffOnlyValues? element, Boolean? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
  //{
  //  if (element != null)
  //  {
  //    if (element == OnOffOnlyValues.On && value == true)
  //      return true;
  //    if (element == OnOffOnlyValues.Off && value == false)
  //      return true;
  //    diffs?.Add(callerName, "Value
  //    return false;
  //  }
  //  return value == null;
  //}

  public static Boolean? GetValue(OnOffOnlyType? element)
  {
    if (element?.Val?.Value != null)
      return element?.Val?.Value == OnOffOnlyValues.On;
    return null;
  }

  public static Boolean CmpValue(OnOffOnlyType? element, Boolean? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
  {
    if (element?.Val?.Value != null && value != null)
    {
      if (element.Val.Value == OnOffOnlyValues.On && value == true)
        return true;
      if (element.Val.Value == OnOffOnlyValues.Off && value == false)
        return true;
      diffs?.Add(callerName, element.GetType().Name, element.Val.Value == OnOffOnlyValues.On, value);
      return false;
    }
    if (element?.Val?.Value == null && value == null)
      return true;
    diffs?.Add(callerName, element?.GetType().Name, element?.Val?.Value == OnOffOnlyValues.On, value);
    return false;
  }

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

  public static bool CmpValue(DX.TypedOpenXmlLeafTextElement element, bool? value, DiffList? diffs, string? objName)
  {
    if (GetValue(element) == value)
      return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Text, value);
    return false;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Boolean? value)
  where OpenXmlElementType : OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      if (valProperty != null)
        valProperty.SetValue(element, (bool)value ? OnOffOnlyValues.On : OnOffOnlyValues.Off);
      else if (element is DX.TypedOpenXmlLeafTextElement textElement)
        textElement.Text = (bool)value ? "true" : "false";
      return element;
    }
    return null;
  }
}