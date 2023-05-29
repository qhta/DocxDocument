namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public static class BlurConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXDraw.Blur openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXDraw.Blur openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXDraw.Blur openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  private static Boolean? GetGrow(DXDraw.Blur openXmlElement)
  {
    return openXmlElement?.Grow?.Value;
  }
  
  private static bool CmpGrow(DXDraw.Blur openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Grow?.Value == value) return true;
    diffs?.Add(objName, "Grow", openXmlElement?.Grow?.Value, value);
    return false;
  }
  
  private static void SetGrow(DXDraw.Blur openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grow = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Grow = null;
  }
  
  public static DocumentModel.Drawings.Blur? CreateModelElement(DXDraw.Blur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blur();
      value.Radius = GetRadius(openXmlElement);
      value.Grow = GetGrow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Blur? openXmlElement, DMDraws.Blur? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadius(openXmlElement, value.Radius, diffs, objName))
        ok = false;
      if (!CmpGrow(openXmlElement, value.Grow, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Blur value)
    where OpenXmlElementType: DXDraw.Blur, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Blur openXmlElement, DMDraws.Blur value)
  {
    SetRadius(openXmlElement, value?.Radius);
    SetGrow(openXmlElement, value?.Grow);
  }
}
