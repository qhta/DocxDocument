namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetBlurRadius(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  private static bool CmpBlurRadius(DXO10W.Reflection openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.BlurRadius?.Value == value) return true;
    diffs?.Add(objName, "BlurRadius", openXmlElement?.BlurRadius?.Value, value);
    return false;
  }
  
  private static void SetBlurRadius(DXO10W.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartingOpacity(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.StartingOpacity?.Value;
  }
  
  private static bool CmpStartingOpacity(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.StartingOpacity?.Value == value) return true;
    diffs?.Add(objName, "StartingOpacity", openXmlElement?.StartingOpacity?.Value, value);
    return false;
  }
  
  private static void SetStartingOpacity(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartingOpacity = value;
  }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartPosition(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.StartPosition?.Value;
  }
  
  private static bool CmpStartPosition(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.StartPosition?.Value == value) return true;
    diffs?.Add(objName, "StartPosition", openXmlElement?.StartPosition?.Value, value);
    return false;
  }
  
  private static void SetStartPosition(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndingOpacity(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.EndingOpacity?.Value;
  }
  
  private static bool CmpEndingOpacity(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.EndingOpacity?.Value == value) return true;
    diffs?.Add(objName, "EndingOpacity", openXmlElement?.EndingOpacity?.Value, value);
    return false;
  }
  
  private static void SetEndingOpacity(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndingOpacity = value;
  }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndPosition(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.EndPosition?.Value;
  }
  
  private static bool CmpEndPosition(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.EndPosition?.Value == value) return true;
    diffs?.Add(objName, "EndPosition", openXmlElement?.EndPosition?.Value, value);
    return false;
  }
  
  private static void SetEndPosition(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetDistanceFromText(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.DistanceFromText?.Value;
  }
  
  private static bool CmpDistanceFromText(DXO10W.Reflection openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DistanceFromText?.Value == value) return true;
    diffs?.Add(objName, "DistanceFromText", openXmlElement?.DistanceFromText?.Value, value);
    return false;
  }
  
  private static void SetDistanceFromText(DXO10W.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDirectionAngle(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.DirectionAngle?.Value;
  }
  
  private static bool CmpDirectionAngle(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DirectionAngle?.Value == value) return true;
    diffs?.Add(objName, "DirectionAngle", openXmlElement?.DirectionAngle?.Value, value);
    return false;
  }
  
  private static void SetDirectionAngle(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFadeDirection(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.FadeDirection?.Value;
  }
  
  private static bool CmpFadeDirection(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FadeDirection?.Value == value) return true;
    diffs?.Add(objName, "FadeDirection", openXmlElement?.FadeDirection?.Value, value);
    return false;
  }
  
  private static void SetFadeDirection(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalScalingFactor(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.HorizontalScalingFactor?.Value;
  }
  
  private static bool CmpHorizontalScalingFactor(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalScalingFactor?.Value == value) return true;
    diffs?.Add(objName, "HorizontalScalingFactor", openXmlElement?.HorizontalScalingFactor?.Value, value);
    return false;
  }
  
  private static void SetHorizontalScalingFactor(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalScalingFactor(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.VerticalScalingFactor?.Value;
  }
  
  private static bool CmpVerticalScalingFactor(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalScalingFactor?.Value == value) return true;
    diffs?.Add(objName, "VerticalScalingFactor", openXmlElement?.VerticalScalingFactor?.Value, value);
    return false;
  }
  
  private static void SetVerticalScalingFactor(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalSkewAngle(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.HorizontalSkewAngle?.Value;
  }
  
  private static bool CmpHorizontalSkewAngle(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalSkewAngle?.Value == value) return true;
    diffs?.Add(objName, "HorizontalSkewAngle", openXmlElement?.HorizontalSkewAngle?.Value, value);
    return false;
  }
  
  private static void SetHorizontalSkewAngle(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalSkewAngle(DXO10W.Reflection openXmlElement)
  {
    return openXmlElement?.VerticalSkewAngle?.Value;
  }
  
  private static bool CmpVerticalSkewAngle(DXO10W.Reflection openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalSkewAngle?.Value == value) return true;
    diffs?.Add(objName, "VerticalSkewAngle", openXmlElement?.VerticalSkewAngle?.Value, value);
    return false;
  }
  
  private static void SetVerticalSkewAngle(DXO10W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.RectangleAlignmentKind? GetAlignment(DXO10W.Reflection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO10W.Reflection openXmlElement, DMW.RectangleAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXO10W.Reflection openXmlElement, DMW.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(value);
  }
  
  public static DMW.Reflection? CreateModelElement(DXO10W.Reflection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Reflection();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.StartingOpacity = GetStartingOpacity(openXmlElement);
      value.StartPosition = GetStartPosition(openXmlElement);
      value.EndingOpacity = GetEndingOpacity(openXmlElement);
      value.EndPosition = GetEndPosition(openXmlElement);
      value.DistanceFromText = GetDistanceFromText(openXmlElement);
      value.DirectionAngle = GetDirectionAngle(openXmlElement);
      value.FadeDirection = GetFadeDirection(openXmlElement);
      value.HorizontalScalingFactor = GetHorizontalScalingFactor(openXmlElement);
      value.VerticalScalingFactor = GetVerticalScalingFactor(openXmlElement);
      value.HorizontalSkewAngle = GetHorizontalSkewAngle(openXmlElement);
      value.VerticalSkewAngle = GetVerticalSkewAngle(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.Reflection? openXmlElement, DMW.Reflection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlurRadius(openXmlElement, value.BlurRadius, diffs, objName, propName))
        ok = false;
      if (!CmpStartingOpacity(openXmlElement, value.StartingOpacity, diffs, objName, propName))
        ok = false;
      if (!CmpStartPosition(openXmlElement, value.StartPosition, diffs, objName, propName))
        ok = false;
      if (!CmpEndingOpacity(openXmlElement, value.EndingOpacity, diffs, objName, propName))
        ok = false;
      if (!CmpEndPosition(openXmlElement, value.EndPosition, diffs, objName, propName))
        ok = false;
      if (!CmpDistanceFromText(openXmlElement, value.DistanceFromText, diffs, objName, propName))
        ok = false;
      if (!CmpDirectionAngle(openXmlElement, value.DirectionAngle, diffs, objName, propName))
        ok = false;
      if (!CmpFadeDirection(openXmlElement, value.FadeDirection, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalScalingFactor(openXmlElement, value.HorizontalScalingFactor, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalScalingFactor(openXmlElement, value.VerticalScalingFactor, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalSkewAngle(openXmlElement, value.HorizontalSkewAngle, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalSkewAngle(openXmlElement, value.VerticalSkewAngle, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Reflection value)
    where OpenXmlElementType: DXO10W.Reflection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.Reflection openXmlElement, DMW.Reflection value)
  {
    SetBlurRadius(openXmlElement, value?.BlurRadius);
    SetStartingOpacity(openXmlElement, value?.StartingOpacity);
    SetStartPosition(openXmlElement, value?.StartPosition);
    SetEndingOpacity(openXmlElement, value?.EndingOpacity);
    SetEndPosition(openXmlElement, value?.EndPosition);
    SetDistanceFromText(openXmlElement, value?.DistanceFromText);
    SetDirectionAngle(openXmlElement, value?.DirectionAngle);
    SetFadeDirection(openXmlElement, value?.FadeDirection);
    SetHorizontalScalingFactor(openXmlElement, value?.HorizontalScalingFactor);
    SetVerticalScalingFactor(openXmlElement, value?.VerticalScalingFactor);
    SetHorizontalSkewAngle(openXmlElement, value?.HorizontalSkewAngle);
    SetVerticalSkewAngle(openXmlElement, value?.VerticalSkewAngle);
    SetAlignment(openXmlElement, value?.Alignment);
  }
}
