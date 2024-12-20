namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public static class BlurConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXD.Blur openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXD.Blur openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXD.Blur openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  private static Boolean? GetGrow(DXD.Blur openXmlElement)
  {
    return openXmlElement?.Grow?.Value;
  }
  
  private static bool CmpGrow(DXD.Blur openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Grow?.Value == value) return true;
    diffs?.Add(objName, "Grow", openXmlElement?.Grow?.Value, value);
    return false;
  }
  
  private static void SetGrow(DXD.Blur openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grow = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Grow = null;
  }
  
  public static DMD.Blur? CreateModelElement(DXD.Blur? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Blur();
      value.Radius = GetRadius(openXmlElement);
      value.Grow = GetGrow(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Blur? openXmlElement, DMD.Blur? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadius(openXmlElement, value.Radius, diffs, objName, propName))
        ok = false;
      if (!CmpGrow(openXmlElement, value.Grow, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Blur value)
    where OpenXmlElementType: DXD.Blur, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Blur openXmlElement, DMD.Blur value)
  {
    SetRadius(openXmlElement, value?.Radius);
    SetGrow(openXmlElement, value?.Grow);
  }
}
