namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteType Class.
/// </summary>
public static class FootnoteEndnoteTypeConverter
{
  /// <summary>
  /// Footnote/Endnote Type
  /// </summary>
  public static DocumentModel.Wordprocessing.FootnoteEndnoteKind? GetType(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteValues, DocumentModel.Wordprocessing.FootnoteEndnoteKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement, DocumentModel.Wordprocessing.FootnoteEndnoteKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteValues, DocumentModel.Wordprocessing.FootnoteEndnoteKind>(value);
  }
  
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public static Int64? GetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }
  
  public static DocumentModel.Wordprocessing.FootnoteEndnoteType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FootnoteEndnoteType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FootnoteEndnoteType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
