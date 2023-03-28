namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Text Rectangle.
/// </summary>
public static class RectangleConverter
{
  /// <summary>
  /// Left
  /// </summary>
  private static String? GetLeft(DXDraw.Rectangle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Left);
  }
  
  private static bool CmpLeft(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Left, value, diffs, objName, "Left");
  }
  
  private static void SetLeft(DXDraw.Rectangle openXmlElement, String? value)
  {
    openXmlElement.Left = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Top
  /// </summary>
  private static String? GetTop(DXDraw.Rectangle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Top);
  }
  
  private static bool CmpTop(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Top, value, diffs, objName, "Top");
  }
  
  private static void SetTop(DXDraw.Rectangle openXmlElement, String? value)
  {
    openXmlElement.Top = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Right
  /// </summary>
  private static String? GetRight(DXDraw.Rectangle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Right);
  }
  
  private static bool CmpRight(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Right, value, diffs, objName, "Right");
  }
  
  private static void SetRight(DXDraw.Rectangle openXmlElement, String? value)
  {
    openXmlElement.Right = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  private static String? GetBottom(DXDraw.Rectangle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Bottom);
  }
  
  private static bool CmpBottom(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Bottom, value, diffs, objName, "Bottom");
  }
  
  private static void SetBottom(DXDraw.Rectangle openXmlElement, String? value)
  {
    openXmlElement.Bottom = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Rectangle? CreateModelElement(DXDraw.Rectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Rectangle();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Rectangle? openXmlElement, DMDraws.Rectangle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Rectangle value)
    where OpenXmlElementType: DXDraw.Rectangle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Rectangle openXmlElement, DMDraws.Rectangle value)
  {
    SetLeft(openXmlElement, value?.Left);
    SetTop(openXmlElement, value?.Top);
    SetRight(openXmlElement, value?.Right);
    SetBottom(openXmlElement, value?.Bottom);
  }
}
