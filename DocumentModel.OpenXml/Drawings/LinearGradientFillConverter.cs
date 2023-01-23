namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public static class LinearGradientFillConverter
{
  /// <summary>
  /// Angle
  /// </summary>
  private static Int32? GetAngle(DXDraw.LinearGradientFill openXmlElement)
  {
    return openXmlElement.Angle?.Value;
  }
  
  private static bool CmpAngle(DXDraw.LinearGradientFill openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Angle?.Value == value;
  }
  
  private static void SetAngle(DXDraw.LinearGradientFill openXmlElement, Int32? value)
  {
    openXmlElement.Angle = value;
  }
  
  /// <summary>
  /// Scaled
  /// </summary>
  private static Boolean? GetScaled(DXDraw.LinearGradientFill openXmlElement)
  {
    return openXmlElement?.Scaled?.Value;
  }
  
  private static bool CmpScaled(DXDraw.LinearGradientFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Scaled?.Value == value;
  }
  
  private static void SetScaled(DXDraw.LinearGradientFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Scaled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Scaled = null;
  }
  
  public static DMDraws.LinearGradientFill? CreateModelElement(DXDraw.LinearGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LinearGradientFill();
      value.Angle = GetAngle(openXmlElement);
      value.Scaled = GetScaled(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LinearGradientFill? openXmlElement, DMDraws.LinearGradientFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAngle(openXmlElement, value.Angle, diffs, objName))
        ok = false;
      if (!CmpScaled(openXmlElement, value.Scaled, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LinearGradientFill? value)
    where OpenXmlElementType: DXDraw.LinearGradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetScaled(openXmlElement, value?.Scaled);
      return openXmlElement;
    }
    return default;
  }
}
