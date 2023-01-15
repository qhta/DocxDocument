using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using PageOrientation = DocumentModel.Drawings.ChartDrawings.PageOrientation;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageSetup Class.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  ///   paperSize, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetPaperSize(PageSetup? openXmlElement)
  {
    return openXmlElement?.PaperSize?.Value;
  }

  public static void SetPaperSize(PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PaperSize = value;
  }

  /// <summary>
  ///   firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetFirstPageNumber(PageSetup? openXmlElement)
  {
    return openXmlElement?.FirstPageNumber?.Value;
  }

  public static void SetFirstPageNumber(PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstPageNumber = value;
  }

  /// <summary>
  ///   orientation, this property is only available in Office 2016 and later.
  /// </summary>
  public static PageOrientation? GetOrientation(PageSetup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, PageOrientation>(openXmlElement?.Orientation?.Value);
  }

  public static void SetOrientation(PageSetup? openXmlElement, PageOrientation? value)
  {
    if (openXmlElement != null)
      openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation, PageOrientation>(value);
  }

  /// <summary>
  ///   blackAndWhite, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetBlackAndWhite(PageSetup? openXmlElement)
  {
    return openXmlElement?.BlackAndWhite?.Value;
  }

  public static void SetBlackAndWhite(PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BlackAndWhite = null;
  }

  /// <summary>
  ///   draft, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetDraft(PageSetup? openXmlElement)
  {
    return openXmlElement?.Draft?.Value;
  }

  public static void SetDraft(PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Draft = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Draft = null;
  }

  /// <summary>
  ///   useFirstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetUseFirstPageNumber(PageSetup? openXmlElement)
  {
    return openXmlElement?.UseFirstPageNumber?.Value;
  }

  public static void SetUseFirstPageNumber(PageSetup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseFirstPageNumber = null;
  }

  /// <summary>
  ///   horizontalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetHorizontalDpi(PageSetup? openXmlElement)
  {
    return openXmlElement?.HorizontalDpi?.Value;
  }

  public static void SetHorizontalDpi(PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalDpi = value;
  }

  /// <summary>
  ///   verticalDpi, this property is only available in Office 2016 and later.
  /// </summary>
  public static Int32? GetVerticalDpi(PageSetup? openXmlElement)
  {
    return openXmlElement?.VerticalDpi?.Value;
  }

  public static void SetVerticalDpi(PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalDpi = value;
  }

  /// <summary>
  ///   copies, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetCopies(PageSetup? openXmlElement)
  {
    return openXmlElement?.Copies?.Value;
  }

  public static void SetCopies(PageSetup? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Copies = value;
  }

  public static DocumentModel.Drawings.ChartDrawings.PageSetup? CreateModelElement(PageSetup? openXmlElement)
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
    where OpenXmlElementType : PageSetup, new()
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