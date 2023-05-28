namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the RelativeRectangleType Class.
/// </summary>
public static class RelativeRectangleTypeConverter
{
  /// <summary>
  /// Left Offset
  /// </summary>
  private static Int32? GetLeft(DXD.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXD.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Left?.Value == value) return true;
    diffs?.Add(objName, "Left", openXmlElement?.Left?.Value, value);
    return false;
  }
  
  private static void SetLeft(DXD.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Left = value;
  }
  
  /// <summary>
  /// Top Offset
  /// </summary>
  private static Int32? GetTop(DXD.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXD.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Top?.Value == value) return true;
    diffs?.Add(objName, "Top", openXmlElement?.Top?.Value, value);
    return false;
  }
  
  private static void SetTop(DXD.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Top = value;
  }
  
  /// <summary>
  /// Right Offset
  /// </summary>
  private static Int32? GetRight(DXD.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXD.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Right?.Value == value) return true;
    diffs?.Add(objName, "Right", openXmlElement?.Right?.Value, value);
    return false;
  }
  
  private static void SetRight(DXD.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Right = value;
  }
  
  /// <summary>
  /// Bottom Offset
  /// </summary>
  private static Int32? GetBottom(DXD.RelativeRectangleType openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXD.RelativeRectangleType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Bottom?.Value == value) return true;
    diffs?.Add(objName, "Bottom", openXmlElement?.Bottom?.Value, value);
    return false;
  }
  
  private static void SetBottom(DXD.RelativeRectangleType openXmlElement, Int32? value)
  {
    openXmlElement.Bottom = value;
  }
  
  public static DMD.RelativeRectangleType? CreateModelElement(DXD.RelativeRectangleType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.RelativeRectangleType();
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Right = GetRight(openXmlElement);
      value.Bottom = GetBottom(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.RelativeRectangleType? openXmlElement, DMD.RelativeRectangleType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeft(openXmlElement, value.Left, diffs, objName, propName))
        ok = false;
      if (!CmpTop(openXmlElement, value.Top, diffs, objName, propName))
        ok = false;
      if (!CmpRight(openXmlElement, value.Right, diffs, objName, propName))
        ok = false;
      if (!CmpBottom(openXmlElement, value.Bottom, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.RelativeRectangleType value)
    where OpenXmlElementType: DXD.RelativeRectangleType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.RelativeRectangleType openXmlElement, DMD.RelativeRectangleType value)
  {
    SetLeft(openXmlElement, value?.Left);
    SetTop(openXmlElement, value?.Top);
    SetRight(openXmlElement, value?.Right);
    SetBottom(openXmlElement, value?.Bottom);
  }
}
