namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Page Margins.
/// </summary>
public static class PageMarginsConverter
{
  /// <summary>
  /// Left
  /// </summary>
  private static Double? GetLeft(DXDC.PageMargins openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXDC.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Left?.Value == value) return true;
    diffs?.Add(objName, "Left", openXmlElement?.Left?.Value, value);
    return false;
  }
  
  private static void SetLeft(DXDC.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  private static Double? GetRight(DXDC.PageMargins openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXDC.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Right?.Value == value) return true;
    diffs?.Add(objName, "Right", openXmlElement?.Right?.Value, value);
    return false;
  }
  
  private static void SetRight(DXDC.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  private static Double? GetTop(DXDC.PageMargins openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXDC.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Top?.Value == value) return true;
    diffs?.Add(objName, "Top", openXmlElement?.Top?.Value, value);
    return false;
  }
  
  private static void SetTop(DXDC.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Bottom
  /// </summary>
  private static Double? GetBottom(DXDC.PageMargins openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXDC.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bottom?.Value == value) return true;
    diffs?.Add(objName, "Bottom", openXmlElement?.Bottom?.Value, value);
    return false;
  }
  
  private static void SetBottom(DXDC.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Bottom = value;
  }
  
  /// <summary>
  /// Header
  /// </summary>
  private static Double? GetHeader(DXDC.PageMargins openXmlElement)
  {
    return openXmlElement?.Header?.Value;
  }
  
  private static bool CmpHeader(DXDC.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Header?.Value == value) return true;
    diffs?.Add(objName, "Header", openXmlElement?.Header?.Value, value);
    return false;
  }
  
  private static void SetHeader(DXDC.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Header = value;
  }
  
  /// <summary>
  /// Footer
  /// </summary>
  private static Double? GetFooter(DXDC.PageMargins openXmlElement)
  {
    return openXmlElement?.Footer?.Value;
  }
  
  private static bool CmpFooter(DXDC.PageMargins openXmlElement, Double? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Footer?.Value == value) return true;
    diffs?.Add(objName, "Footer", openXmlElement?.Footer?.Value, value);
    return false;
  }
  
  private static void SetFooter(DXDC.PageMargins openXmlElement, Double? value)
  {
    openXmlElement.Footer = value;
  }
  
  public static DMD.Charts.PageMargins? CreateModelElement(DXDC.PageMargins? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.PageMargins();
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
  
  public static bool CompareModelElement(DXDC.PageMargins? openXmlElement, DMDC.PageMargins? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName, propName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName, propName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName, propName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName, propName))
        ok = false;
      if (!CmpHeader(openXmlElement, value.Header, diffs, objName, propName))
        ok = false;
      if (!CmpFooter(openXmlElement, value.Footer, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PageMargins value)
    where OpenXmlElementType: DXDC.PageMargins, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PageMargins openXmlElement, DMDC.PageMargins value)
  {
    SetLeft(openXmlElement, value?.Left);
    SetRight(openXmlElement, value?.Right);
    SetTop(openXmlElement, value?.Top);
    SetBottom(openXmlElement, value?.Bottom);
    SetHeader(openXmlElement, value?.Header);
    SetFooter(openXmlElement, value?.Footer);
  }
}
