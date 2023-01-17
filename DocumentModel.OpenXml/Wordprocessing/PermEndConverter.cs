namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public static class PermEndConverter
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  private static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.PermEnd openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.PermEnd openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  private static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.PermEnd openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.PermEnd openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.PermEnd? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PermEnd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PermEnd();
      value.Id = GetId(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PermEnd? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PermEnd, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      return openXmlElement;
    }
    return default;
  }
}
