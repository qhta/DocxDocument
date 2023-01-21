namespace DocumentModel.OpenXml;

public static class StringValueConverter
{
  public static string GetValue(DX.StringValue element)
  {
    return element.Value ?? string.Empty;
  }

  public static string GetValue(DXW.StringType element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  public static string GetValue(DXW.String255Type element)
  {
    return element.Val?.Value ?? string.Empty;
  }

  public static string GetValue(DX.TypedOpenXmlLeafTextElement element)
  {
    return element.Text;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(string value) where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val") ??
                      typeof(OpenXmlElementType).GetProperty("Text");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }
}