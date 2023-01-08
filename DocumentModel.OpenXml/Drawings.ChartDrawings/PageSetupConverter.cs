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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPaperSize(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlackAndWhite(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDraft(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDraft(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetUseFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUseFirstPageNumber(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetHorizontalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetVerticalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalDpi(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetCopies(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCopies(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageSetup? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
