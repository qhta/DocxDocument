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
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXW.PageMargin openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Top?.Value == value) return true;
    diffs?.Add(objName, "Top", openXmlElement?.Top?.Value, value);
    return false;
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
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Right?.Value == value) return true;
    diffs?.Add(objName, "Right", openXmlElement?.Right?.Value, value);
    return false;
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
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXW.PageMargin openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bottom?.Value == value) return true;
    diffs?.Add(objName, "Bottom", openXmlElement?.Bottom?.Value, value);
    return false;
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
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Left?.Value == value) return true;
    diffs?.Add(objName, "Left", openXmlElement?.Left?.Value, value);
    return false;
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
    return openXmlElement?.Header?.Value;
  }
  
  private static bool CmpHeader(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Header?.Value == value) return true;
    diffs?.Add(objName, "Header", openXmlElement?.Header?.Value, value);
    return false;
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
    return openXmlElement?.Footer?.Value;
  }
  
  private static bool CmpFooter(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Footer?.Value == value) return true;
    diffs?.Add(objName, "Footer", openXmlElement?.Footer?.Value, value);
    return false;
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
    return openXmlElement?.Gutter?.Value;
  }
  
  private static bool CmpGutter(DXW.PageMargin openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Gutter?.Value == value) return true;
    diffs?.Add(objName, "Gutter", openXmlElement?.Gutter?.Value, value);
    return false;
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
  
  public static bool CompareModelElement(DXW.PageMargin? openXmlElement, DMW.PageMargin? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName, propName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName, propName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName, propName))
        ok = false;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName, propName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName, propName))
        ok = false;
      if (!CmpFooter(openXmlElement, value.Footer, diffs, objName, propName))
        ok = false;
      if (!CmpGutter(openXmlElement, value.Gutter, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PageMargin value)
    where OpenXmlElementType: DXW.PageMargin, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PageMargin openXmlElement, DMW.PageMargin value)
  {
    SetTop(openXmlElement, value?.Top);
    SetRight(openXmlElement, value?.Right);
    SetBottom(openXmlElement, value?.Bottom);
    SetLeft(openXmlElement, value?.Left);
    SetHeader(openXmlElement, value?.Header);
    SetFooter(openXmlElement, value?.Footer);
    SetGutter(openXmlElement, value?.Gutter);
  }
}
