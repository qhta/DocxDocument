namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageMargin Class.
/// </summary>
public static class PageMarginConverter
{
  /// <summary>
  /// Top Margin Spacing
  /// </summary>
  private static Int32? GetTop(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static void SetTop(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Margin Spacing
  /// </summary>
  private static UInt32? GetRight(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static void SetRight(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Page Bottom Spacing
  /// </summary>
  private static Int32? GetBottom(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static void SetBottom(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  /// <summary>
  /// Left Margin Spacing
  /// </summary>
  private static UInt32? GetLeft(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static void SetLeft(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Spacing to Top of Header
  /// </summary>
  private static UInt32? GetHeader(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Header?.Value;
  }
  
  private static void SetHeader(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// Spacing to Bottom of Footer
  /// </summary>
  private static UInt32? GetFooter(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Footer?.Value;
  }
  
  private static void SetFooter(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Footer = value;
  }
  
  /// <summary>
  /// Page Gutter Spacing
  /// </summary>
  private static UInt32? GetGutter(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement)
  {
    return openXmlElement.Gutter?.Value;
  }
  
  private static void SetGutter(DocumentFormat.OpenXml.Wordprocessing.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Gutter = value;
  }
  
  public static DocumentModel.Wordprocessing.PageMargin? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PageMargin? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PageMargin, new()
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
