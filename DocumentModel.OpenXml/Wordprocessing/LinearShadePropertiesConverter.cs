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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
