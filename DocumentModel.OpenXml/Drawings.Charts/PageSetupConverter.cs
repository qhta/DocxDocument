using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using PageSetup = DocumentFormat.OpenXml.Drawing.Charts.PageSetup;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Page Setup.
/// </summary>
public static class PageSetupConverter
{
  /// <summary>
  ///   Page Size
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
  ///   First Page Number
  /// </summary>
  public static Int32? GetFirstPageNumber(PageSetup? openXmlElement)
  {
    return openXmlElement?.FirstPageNumber?.Value;
  }

  public static void SetFirstPageNumber(PageSetup? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstPageNumber = value;
  }

  /// <summary>
  ///   Orientation
  /// </summary>
  public static PageSetupOrientationKind? GetOrientation(PageSetup? openXmlElement)
  {
    return EnumValueConverter.GetValue<PageSetupOrientationValues, PageSetupOrientationKind>(openXmlElement?.Orientation?.Value);
  }

  public static void SetOrientation(PageSetup? openXmlElement, PageSetupOrientationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Orientation = EnumValueConverter.CreateEnumValue<PageSetupOrientationValues, PageSetupOrientationKind>(value);
  }

  /// <summary>
  ///   Black and White
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
  ///   Draft
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
  ///   Use First Page Number
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
  ///   Horizontal DPI
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
  ///   Vertical DPI
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
  ///   Copies
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

  public static DocumentModel.Drawings.Charts.PageSetup? CreateModelElement(PageSetup? openXmlElement)
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