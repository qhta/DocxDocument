using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public static class PageMarginConverter
{
  /// <summary>
  ///   Top Margin Spacing
  /// </summary>
  public static Int32? GetTop(PageMargin? openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }

  public static void SetTop(PageMargin? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Top = value;
  }

  /// <summary>
  ///   Right Margin Spacing
  /// </summary>
  public static UInt32? GetRight(PageMargin? openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }

  public static void SetRight(PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Right = value;
  }

  /// <summary>
  ///   Page Bottom Spacing
  /// </summary>
  public static Int32? GetBottom(PageMargin? openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }

  public static void SetBottom(PageMargin? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Bottom = value;
  }

  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  public static UInt32? GetLeft(PageMargin? openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }

  public static void SetLeft(PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Left = value;
  }

  /// <summary>
  ///   Spacing to Top of Header
  /// </summary>
  public static UInt32? GetHeader(PageMargin? openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }

  public static void SetHeader(PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Header = value;
  }

  /// <summary>
  ///   Spacing to Bottom of Footer
  /// </summary>
  public static UInt32? GetFooter(PageMargin? openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }

  public static void SetFooter(PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Footer = value;
  }

  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  public static UInt32? GetGutter(PageMargin? openXmlElement)
  {
    return openXmlElement?.Gutter?.Value;
  }

  public static void SetGutter(PageMargin? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Gutter = value;
  }

  public static DocumentModel.Wordprocessing.PageMargin? CreateModelElement(PageMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageMargin();
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      value.Left = GetLeft(openXmlElement);
      value.Header = GetHeader(openXmlElement);
      value.Footer = GetFooter(openXmlElement);
      value.Gutter = GetGutter(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PageMargin? value)
    where OpenXmlElementType : PageMargin, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTop(openXmlElement, value?.Top);
      SetRight(openXmlElement, value?.Right);
      SetBottom(openXmlElement, value?.Bottom);
      SetLeft(openXmlElement, value?.Left);
      SetHeader(openXmlElement, value?.Header);
      SetFooter(openXmlElement, value?.Footer);
      SetGutter(openXmlElement, value?.Gutter);
      return openXmlElement;
    }
    return default;
  }
}