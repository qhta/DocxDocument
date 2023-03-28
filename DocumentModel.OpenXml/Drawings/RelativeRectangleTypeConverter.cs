namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the RelativeRectangleType Class converter from/to OpenXml.
///</summary>
public static class RelativeRectangleTypeConverter
{
  /// <summary>
  /// Left Offset
  /// </summary>
  private static Int32? GetLeft(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXDraw.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Left?.Value == value) return true;
    diffs?.Add(objName, "Left", openXmlElement?.Left?.Value, value);
    return false;
  }
  
  private static void SetLeft(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  private static Int32? GetTop(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXDraw.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Top?.Value == value) return true;
    diffs?.Add(objName, "Top", openXmlElement?.Top?.Value, value);
    return false;
  }
  
  private static void SetTop(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  private static Int32? GetRight(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXDraw.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Right?.Value == value) return true;
    diffs?.Add(objName, "Right", openXmlElement?.Right?.Value, value);
    return false;
  }
  
  private static void SetRight(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  private static Int32? GetBottom(DXDraw.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXDraw.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Bottom?.Value == value) return true;
    diffs?.Add(objName, "Bottom", openXmlElement?.Bottom?.Value, value);
    return false;
  }
  
  private static void SetBottom(DXDraw.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  public static DocumentModel.Drawings.RelativeRectangleType? CreateModelElement(DXDraw.RelativeRectangleType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RelativeRectangleType();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.RelativeRectangleType? openXmlElement, DMDraws.RelativeRectangleType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RelativeRectangleType value)
    where OpenXmlElementType: DXDraw.RelativeRectangleType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.RelativeRectangleType openXmlElement, DMDraws.RelativeRectangleType value)
  {
    SetLeft(openXmlElement, value?.Left);
    SetTop(openXmlElement, value?.Top);
    SetRight(openXmlElement, value?.Right);
    SetBottom(openXmlElement, value?.Bottom);
  }
}
