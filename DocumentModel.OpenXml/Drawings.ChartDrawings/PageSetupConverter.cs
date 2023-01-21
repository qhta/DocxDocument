namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PageSetup Class.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  /// paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPaperSize(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement.PaperSize?.Value;
  }
  
  private static void SetPaperSize(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.PaperSize = value;
  }
  
  /// <summary>
  /// firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement.FirstPageNumber?.Value;
  }
  
  private static void SetFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.FirstPageNumber = value;
  }
  
  /// <summary>
  /// orientation, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.PageOrientation? GetOrientation(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDrawsChartDraws.PageOrientation>(openXmlElement?.Orientation?.Value);
  }
  
  private static void SetOrientation(DXO2016DrawChartDraw.PageSetup openXmlElement, DMDrawsChartDraws.PageOrientation? value)
  {
    openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, DMDrawsChartDraws.PageOrientation>(value);
  }
  
  /// <summary>
  /// blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetBlackAndWhite(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.BlackAndWhite?.Value;
  }
  
  private static void SetBlackAndWhite(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlackAndWhite = null;
  }
  
  /// <summary>
  /// draft, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetDraft(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }
  
  private static void SetDraft(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Draft = null;
  }
  
  /// <summary>
  /// useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetUseFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }
  
  private static void SetUseFirstPageNumber(DXO2016DrawChartDraw.PageSetup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.UseFirstPageNumber = null;
  }
  
  /// <summary>
  /// horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetHorizontalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement.HorizontalDpi?.Value;
  }
  
  private static void SetHorizontalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalDpi = value;
  }
  
  /// <summary>
  /// verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetVerticalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement.VerticalDpi?.Value;
  }
  
  private static void SetVerticalDpi(DXO2016DrawChartDraw.PageSetup openXmlElement, Int32? value)
  {
    openXmlElement.VerticalDpi = value;
  }
  
  /// <summary>
  /// copies, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetCopies(DXO2016DrawChartDraw.PageSetup openXmlElement)
  {
    return openXmlElement.Copies?.Value;
  }
  
  private static void SetCopies(DXO2016DrawChartDraw.PageSetup openXmlElement, UInt32? value)
  {
    openXmlElement.Copies = value;
  }
  
  public static DMDrawsChartDraws.PageSetup? CreateModelElement(DXO2016DrawChartDraw.PageSetup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.PageSetup();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PageSetup? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PageSetup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPaperSize(openXmlElement, value?.PaperSize);
      SetFirstPageNumber(openXmlElement, value?.FirstPageNumber);
      SetOrientation(openXmlElement, value?.Orientation);
      SetBlackAndWhite(openXmlElement, value?.BlackAndWhite);
      SetDraft(openXmlElement, value?.Draft);
      SetUseFirstPageNumber(openXmlElement, value?.UseFirstPageNumber);
      SetHorizontalDpi(openXmlElement, value?.HorizontalDpi);
      SetVerticalDpi(openXmlElement, value?.VerticalDpi);
      SetCopies(openXmlElement, value?.Copies);
      return openXmlElement;
    }
    return default;
  }
}
