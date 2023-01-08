namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public static class PathShadePropertiesConverter
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.PathShadeKind? GetPath(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DocumentModel.Wordprocessing.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  public static void SetPath(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement, DocumentModel.Wordprocessing.PathShadeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PathShadeTypeValues, DocumentModel.Wordprocessing.PathShadeKind>(value);
  }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public static DocumentModel.Wordprocessing.FillToRectangle? GetFillToRectangle(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFillToRectangle(DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties? openXmlElement, DocumentModel.Wordprocessing.FillToRectangle? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
