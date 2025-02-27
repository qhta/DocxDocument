namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public static class LinearGradientFillConverter
{
  /// <summary>
  /// Angle
  /// </summary>
  private static Int32? GetAngle(DXD.LinearGradientFill openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  private static bool CmpAngle(DXD.LinearGradientFill openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Angle?.Value == value) return true;
    diffs?.Add(objName, "Angle", openXmlElement?.Angle?.Value, value);
    return false;
  }
  
  private static void SetAngle(DXD.LinearGradientFill openXmlElement, Int32? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  private static Boolean GetScaled(DXD.LinearGradientFill openXmlElement)
  {
    return openXmlElement?.Scaled?.Value ?? false;
  }
  
  private static bool CmpScaled(DXD.LinearGradientFill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Scaled?.Value == value) return true;
    diffs?.Add(objName, "Scaled", openXmlElement?.Scaled?.Value, value);
    return false;
  }
  
  private static void SetScaled(DXD.LinearGradientFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Scaled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Scaled = null;
  }
  
  public static DMD.LinearGradientFill? CreateModelElement(DXD.LinearGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.LinearGradientFill();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.LinearGradientFill? openXmlElement, DMD.LinearGradientFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName, propName))
        ok = false;
      if (!CmpScaled(openXmlElement, value.Scaled, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LinearGradientFill value)
    where OpenXmlElementType: DXD.LinearGradientFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.LinearGradientFill openXmlElement, DMD.LinearGradientFill value)
  {
    SetAngle(openXmlElement, value?.Angle);
    SetScaled(openXmlElement, value?.Scaled);
  }
}
