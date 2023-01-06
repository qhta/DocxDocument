namespace DocumentModel.OpenXml;

public static class StringConverter
{
  public static string CreateModelElement(TypedOpenXmlLeafTextElement element)
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