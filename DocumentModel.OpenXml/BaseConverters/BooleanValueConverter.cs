using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

public static class BooleanValueConverter
{
  public static Boolean? GetValue(OnOffOnlyValues? element)
  {
    if (element != null)
      return element == OnOffOnlyValues.On;
    return null;
  }

  public static Boolean CmpValue(OnOffOnlyValues? element, Boolean? value)
  {
    if (element != null)
    {
      if (value == true)
        return element == OnOffOnlyValues.On;
      if (value == false)
        return element == OnOffOnlyValues.Off;
      return false;
    }
    return value == null;
  }

  public static Boolean? GetValue(OnOffOnlyType? element)
  {
    if (element?.Val?.Value != null)
      return element?.Val?.Value == OnOffOnlyValues.On;
    return null;
  }

  public static Boolean CmpValue(OnOffOnlyType? element, Boolean? value)
  {
    if (element?.Val?.Value != null)
    {
      if (value == true)
        return element?.Val?.Value == OnOffOnlyValues.On;
      if (value == false)
        return element?.Val?.Value == OnOffOnlyValues.Off;
      return false;
    }
    return value == null;
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
      return element;
    }
    return null;
  }
}