namespace DocumentModel.OpenXml;

public static class StringValueConverter
{
  public static string GetValue(TypedOpenXmlLeafTextElement element)
  {
    return element.Text;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(string str) where OpenXmlElementType : OpenXmlLeafTextElement, new()
  {
    var element = new OpenXmlElementType();
    element.Text = str;
    return element;
  }
}