namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetPaperSize(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.PaperSize?.Value;
  }
  
  public static void SetPaperSize(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PaperSize = value;
  }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.FirstPageNumber?.Value;
  }
  
  public static void SetFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstPageNumber = value;
  }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.PageOrientation? GetOrientation(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DocumentModel.Drawings.ChartDrawings.PageOrientation>(openXmlElement?.Orientation?.Value);
  }
  
  public static void SetOrientation(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, DocumentModel.Drawings.ChartDrawings.PageOrientation? value)
  {
    if (openXmlElement != null)
      openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DocumentModel.Drawings.ChartDrawings.PageOrientation>(value);
  }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetBlackAndWhite(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.BlackAndWhite?.Value;
  }
  
  public static void SetBlackAndWhite(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BlackAndWhite = null;
  }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDraft(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }
  
  public static void SetDraft(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Draft = null;
  }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetUseFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }
  
  public static void SetUseFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseFirstPageNumber = null;
  }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetHorizontalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.HorizontalDpi?.Value;
  }
  
  public static void SetHorizontalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalDpi = value;
  }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetVerticalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.VerticalDpi?.Value;
  }
  
  public static void SetVerticalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalDpi = value;
  }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetCopies(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    return openXmlElement?.Copies?.Value;
  }
  
  public static void SetCopies(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Copies = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PageSetup? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PageSetup();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.PageSetup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
