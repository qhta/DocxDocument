namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Document Background.
/// </summary>
public static class BackgroundConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Background? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public static Boolean? GetFilled(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFilled(DocumentFormat.OpenXml.Vml.Background? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public static String? GetFillcolor(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetFillcolor(DocumentFormat.OpenXml.Vml.Background? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  public static void SetBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.PureBlackWhiteMode?.Value);
  }
  
  public static void SetPureBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.PureBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public static DocumentModel.Vml.BlackAndWhiteMode? GetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(openXmlElement?.NormalBlackWhiteMode?.Value);
  }
  
  public static void SetNormalBlackWhiteMode(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.BlackAndWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.NormalBlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues, DocumentModel.Vml.BlackAndWhiteMode>(value);
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public static DocumentModel.Vml.ScreenSizeKind? GetTargetScreenSize(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DocumentModel.Vml.ScreenSizeKind>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  public static void SetTargetScreenSize(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.ScreenSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues, DocumentModel.Vml.ScreenSizeKind>(value);
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public static DocumentModel.Vml.Fill? GetFill(DocumentFormat.OpenXml.Vml.Background? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFill(DocumentFormat.OpenXml.Vml.Background? openXmlElement, DocumentModel.Vml.Fill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
