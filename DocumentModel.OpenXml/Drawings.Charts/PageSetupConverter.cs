namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Page Setup.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  /// Page Size
  /// </summary>
  public static UInt32? GetPaperSize(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPaperSize(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public static Int32? GetFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Orientation
  /// </summary>
  public static DocumentModel.Drawings.Charts.PageSetupOrientationKind? GetOrientation(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues, DocumentModel.Drawings.Charts.PageSetupOrientationKind>(openXmlElement?.Orientation?.Value);
  }
  
  public static void SetOrientation(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, DocumentModel.Drawings.Charts.PageSetupOrientationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues, DocumentModel.Drawings.Charts.PageSetupOrientationKind>(value);
  }
  
  /// <summary>
  /// Black and White
  /// </summary>
  public static Boolean? GetBlackAndWhite(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlackAndWhite(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Draft
  /// </summary>
  public static Boolean? GetDraft(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDraft(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public static Boolean? GetUseFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUseFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public static Int32? GetHorizontalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public static Int32? GetVerticalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Copies
  /// </summary>
  public static UInt32? GetCopies(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCopies(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
