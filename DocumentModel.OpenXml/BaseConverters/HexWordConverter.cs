namespace DocumentModel.OpenXml;

public static class HexWordConverter
{
  public static HexWord? GetValue(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(HexWord value)
    where OpenXmlElementType : DocumentFormat.OpenXml.OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }

}