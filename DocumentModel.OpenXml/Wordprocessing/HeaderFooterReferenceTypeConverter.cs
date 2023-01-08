namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public static class HeaderFooterReferenceTypeConverter
{
  /// <summary>
  /// type
  /// </summary>
  public static DocumentModel.Wordprocessing.HeaderFooterKind? GetType(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DocumentModel.Wordprocessing.HeaderFooterKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? openXmlElement, DocumentModel.Wordprocessing.HeaderFooterKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DocumentModel.Wordprocessing.HeaderFooterKind>(value);
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
