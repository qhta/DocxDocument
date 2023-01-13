namespace DocumentModel.OpenXml;

public static class StringValueConverter
{

  public static string GetValue(DocumentFormat.OpenXml.StringValue element)
  {
    return element.Value ?? string.Empty;
  }

  public static string GetValue(DocumentFormat.OpenXml.Wordprocessing.StringType element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  public static string GetValue(DocumentFormat.OpenXml.Wordprocessing.String255Type element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  public static string GetValue(TypedOpenXmlLeafTextElement element)
  {
    return element.Text;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(string value) where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val") ??
                      typeof(OpenXmlElementType).GetProperty("Text");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }

}