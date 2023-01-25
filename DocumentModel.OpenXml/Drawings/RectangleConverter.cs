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
    return openXmlElement?.Left?.Value;
  }
  
  private static bool CmpLeft(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Left?.Value == value;
  }
  
  private static void SetLeft(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Left = new StringValue { Value = value };
    else
      openXmlElement.Left = null;
  }
  
  /// <summary>
  /// Top
  /// </summary>
  private static String? GetTop(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Top?.Value;
  }
  
  private static bool CmpTop(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Top?.Value == value;
  }
  
  private static void SetTop(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Top = new StringValue { Value = value };
    else
      openXmlElement.Top = null;
  }
  
  /// <summary>
  /// Right
  /// </summary>
  private static String? GetRight(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Right?.Value;
  }
  
  private static bool CmpRight(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Right?.Value == value;
  }
  
  private static void SetRight(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Right = new StringValue { Value = value };
    else
      openXmlElement.Right = null;
  }
  
  /// <summary>
  /// Bottom Position
  /// </summary>
  private static String? GetBottom(DXDraw.Rectangle openXmlElement)
  {
    return openXmlElement?.Bottom?.Value;
  }
  
  private static bool CmpBottom(DXDraw.Rectangle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Bottom?.Value == value;
  }
  
  private static void SetBottom(DXDraw.Rectangle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Bottom = new StringValue { Value = value };
    else
      openXmlElement.Bottom = null;
  }
  
  public static DMDraws.Rectangle? CreateModelElement(DXDraw.Rectangle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Rectangle();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Rectangle? value)
    where OpenXmlElementType: DXDraw.Rectangle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeft(openXmlElement, value?.Left);
      SetTop(openXmlElement, value?.Top);
      SetRight(openXmlElement, value?.Right);
      SetBottom(openXmlElement, value?.Bottom);
      return openXmlElement;
    }
    return default;
  }
}
