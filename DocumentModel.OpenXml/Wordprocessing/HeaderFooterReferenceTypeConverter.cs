namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public static class HeaderFooterReferenceTypeConverter
{
  /// <summary>
  /// type
  /// </summary>
  private static DocumentModel.Wordprocessing.HeaderFooterKind? GetType(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DocumentModel.Wordprocessing.HeaderFooterKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType openXmlElement, DocumentModel.Wordprocessing.HeaderFooterKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DocumentModel.Wordprocessing.HeaderFooterKind>(value);
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.HeaderFooterReferenceType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.HeaderFooterReferenceType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.HeaderFooterReferenceType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType, new()
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
