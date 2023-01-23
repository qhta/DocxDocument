namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageMargin Class.
/// </summary>
public static class PageMarginConverter
{
  /// <summary>
  /// Top Margin Spacing
  /// </summary>
  private static Int32? GetTop(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Top?.Value;
  }
  
  private static bool CmpTop(DXW.PageMargin openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Top?.Value == value;
  }
  
  private static void SetTop(DXW.PageMargin openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Margin Spacing
  /// </summary>
  private static UInt32? GetRight(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Right?.Value;
  }
  
  private static bool CmpRight(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Right?.Value == value;
  }
  
  private static void SetRight(DXW.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Page Bottom Spacing
  /// </summary>
  private static Int32? GetBottom(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXW.PageMargin openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Bottom?.Value == value;
  }
  
  private static void SetBottom(DXW.PageMargin openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  /// <summary>
  /// Left Margin Spacing
  /// </summary>
  private static UInt32? GetLeft(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Left?.Value;
  }
  
  private static bool CmpLeft(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Left?.Value == value;
  }
  
  private static void SetLeft(DXW.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Spacing to Top of Header
  /// </summary>
  private static UInt32? GetHeader(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Header?.Value;
  }
  
  private static bool CmpHeader(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Header?.Value == value;
  }
  
  private static void SetHeader(DXW.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// Spacing to Bottom of Footer
  /// </summary>
  private static UInt32? GetFooter(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Footer?.Value;
  }
  
  private static bool CmpFooter(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Footer?.Value == value;
  }
  
  private static void SetFooter(DXW.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Footer = value;
  }
  
  /// <summary>
  /// Page Gutter Spacing
  /// </summary>
  private static UInt32? GetGutter(DXW.PageMargin openXmlElement)
  {
    return openXmlElement.Gutter?.Value;
  }
  
  private static bool CmpGutter(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Gutter?.Value == value;
  }
  
  private static void SetGutter(DXW.PageMargin openXmlElement, UInt32? value)
  {
    openXmlElement.Gutter = value;
  }
  
  public static DMW.PageMargin? CreateModelElement(DXW.PageMargin? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PageMargin();
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
  
  public static bool CompareModelElement(DXW.PageMargin? openXmlElement, DMW.PageMargin? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName))
        ok = false;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName))
        ok = false;
      if (!CmpFooter(openXmlElement, value.Footer, diffs, objName))
        ok = false;
      if (!CmpGutter(openXmlElement, value.Gutter, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PageMargin? value)
    where OpenXmlElementType: DXW.PageMargin, new()
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
