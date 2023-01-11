namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public static class LinearShadePropertiesConverter
{
  /// <summary>
  /// ang, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetAngle(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffKind? GetScaled(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(openXmlElement?.Scaled?.Value);
  }
  
  public static void SetScaled(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Scaled = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.LinearShadeProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LinearShadeProperties();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LinearShadeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
