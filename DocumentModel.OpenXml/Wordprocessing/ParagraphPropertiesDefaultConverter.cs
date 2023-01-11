namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesDefaultConverter
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? GetParagraphPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault? openXmlElement, DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
