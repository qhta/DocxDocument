using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

public static class Int32ValueConverter
{

  #region OpenXmlLeafTextElement
  public static Int32? GetValue(OpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      if (Int32.TryParse(element.Text, out var value)) 
       return value;
    }
    return null;
  }

  public static bool CmpValue(OpenXmlLeafTextElement element, Int32? value, DiffList? diffs = null, string? objName = null)
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
    else if (element is OpenXmlLeafTextElement textElement)
      if (value!=null)
        textElement.Text = ((Int32)value).ToString();
    return element;
  }
  #endregion
}