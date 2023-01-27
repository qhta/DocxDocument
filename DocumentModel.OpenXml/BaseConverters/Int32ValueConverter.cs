using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

public static class Int32ValueConverter
{
  public static Int32? GetValue(DX.TypedOpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      if (Int32.TryParse(element.Text, out var value)) 
       return value;
    }
    return null;
  }

  public static bool CmpValue(DX.TypedOpenXmlLeafTextElement element, Int32? value, DiffList? diffs, string? objName)
  {
    if (GetValue(element) == value)
      diffs?.Add(objName, element.GetType().ToString(), element.Text, value);
    return false;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int32? value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    else if (element is DX.TypedOpenXmlLeafTextElement textElement)
      if (value!=null)
        textElement.Text = ((Int32)value).ToString();
    return element;
  }

}