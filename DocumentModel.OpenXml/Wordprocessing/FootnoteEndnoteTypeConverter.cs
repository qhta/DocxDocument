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
  public static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
