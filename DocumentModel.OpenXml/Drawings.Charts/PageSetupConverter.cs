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
    return openXmlElement?.PaperSize?.Value;
  }
  
  public static void SetPaperSize(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PaperSize = value;
  }
  
  /// <summary>
  /// First Page Number
  /// </summary>
  public static Int32? GetFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return openXmlElement?.FirstPageNumber?.Value;
  }
  
  public static void SetFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstPageNumber = value;
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
    return openXmlElement?.BlackAndWhite?.Value;
  }
  
  public static void SetBlackAndWhite(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BlackAndWhite = null;
  }
  
  /// <summary>
  /// Draft
  /// </summary>
  public static Boolean? GetDraft(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }
  
  public static void SetDraft(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Draft = null;
  }
  
  /// <summary>
  /// Use First Page Number
  /// </summary>
  public static Boolean? GetUseFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }
  
  public static void SetUseFirstPageNumber(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseFirstPageNumber = null;
  }
  
  /// <summary>
  /// Horizontal DPI
  /// </summary>
  public static Int32? GetHorizontalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return openXmlElement?.HorizontalDpi?.Value;
  }
  
  public static void SetHorizontalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalDpi = value;
  }
  
  /// <summary>
  /// Vertical DPI
  /// </summary>
  public static Int32? GetVerticalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return openXmlElement?.VerticalDpi?.Value;
  }
  
  public static void SetVerticalDpi(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalDpi = value;
  }
  
  /// <summary>
  /// Copies
  /// </summary>
  public static UInt32? GetCopies(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    return openXmlElement?.Copies?.Value;
  }
  
  public static void SetCopies(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Copies = value;
  }
  
  public static DocumentModel.Drawings.Charts.PageSetup? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PageSetup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PageSetup();
      value.PaperSize = GetPaperSize(openXmlElement);
      value.FirstPageNumber = GetFirstPageNumber(openXmlElement);
      value.Orientation = GetOrientation(openXmlElement);
      value.BlackAndWhite = GetBlackAndWhite(openXmlElement);
      value.Draft = GetDraft(openXmlElement);
      value.UseFirstPageNumber = GetUseFirstPageNumber(openXmlElement);
      value.HorizontalDpi = GetHorizontalDpi(openXmlElement);
      value.VerticalDpi = GetVerticalDpi(openXmlElement);
      value.Copies = GetCopies(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PageSetup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PageSetup, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
