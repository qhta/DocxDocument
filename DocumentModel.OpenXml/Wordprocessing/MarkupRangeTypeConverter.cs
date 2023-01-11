namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupRangeType Class.
/// </summary>
public static class MarkupRangeTypeConverter
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  public static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType? openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MarkupRangeType();
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MarkupRangeType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
