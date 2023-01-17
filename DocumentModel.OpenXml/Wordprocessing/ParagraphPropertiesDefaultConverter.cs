namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesDefaultConverter
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? GetParagraphPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraphPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault openXmlElement, DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.ParagraphPropertiesDefault? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphPropertiesDefault();
      value.ParagraphPropertiesBaseStyle = GetParagraphPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphPropertiesDefault? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphPropertiesBaseStyle(openXmlElement, value?.ParagraphPropertiesBaseStyle);
      return openXmlElement;
    }
    return default;
  }
}
