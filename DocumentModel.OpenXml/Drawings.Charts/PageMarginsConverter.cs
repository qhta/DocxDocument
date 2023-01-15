using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Page Margins.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  ///   Left
  /// </summary>
  public static Double? GetLeft(PageMargins? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }

  public static void SetLeft(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }

  /// <summary>
  ///   Right
  /// </summary>
  public static Double? GetRight(PageMargins? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }

  public static void SetRight(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }

  /// <summary>
  ///   Top
  /// </summary>
  public static Double? GetTop(PageMargins? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }

  public static void SetTop(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }

  /// <summary>
  ///   Bottom
  /// </summary>
  public static Double? GetBottom(PageMargins? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }

  public static void SetBottom(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bottom = value;
  }

  /// <summary>
  ///   Header
  /// </summary>
  public static Double? GetHeader(PageMargins? openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }

  public static void SetHeader(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Header = value;
  }

  /// <summary>
  ///   Footer
  /// </summary>
  public static Double? GetFooter(PageMargins? openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }

  public static void SetFooter(PageMargins? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Footer = value;
  }

  public static DocumentModel.Drawings.Charts.PageMargins? CreateModelElement(PageMargins? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PageMargins();
      value.Left = GetLeft(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      value.Header = GetHeader(openXmlElement);
      value.Footer = GetFooter(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PageMargins? value)
    where OpenXmlElementType : PageMargins, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeft(openXmlElement, value?.Left);
      SetRight(openXmlElement, value?.Right);
      SetTop(openXmlElement, value?.Top);
      SetBottom(openXmlElement, value?.Bottom);
      SetHeader(openXmlElement, value?.Header);
      SetFooter(openXmlElement, value?.Footer);
      return openXmlElement;
    }
    return default;
  }
}