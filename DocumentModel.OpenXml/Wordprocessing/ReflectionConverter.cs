namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetBlurRadius(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.BlurRadius?.Value;
  }
  
  private static bool CmpBlurRadius(DXO2010W.Reflection openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.BlurRadius?.Value == value;
  }
  
  private static void SetBlurRadius(DXO2010W.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartingOpacity(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.StartingOpacity?.Value;
  }
  
  private static bool CmpStartingOpacity(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.StartingOpacity?.Value == value;
  }
  
  private static void SetStartingOpacity(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartingOpacity = value;
  }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartPosition(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.StartPosition?.Value;
  }
  
  private static bool CmpStartPosition(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.StartPosition?.Value == value;
  }
  
  private static void SetStartPosition(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndingOpacity(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.EndingOpacity?.Value;
  }
  
  private static bool CmpEndingOpacity(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.EndingOpacity?.Value == value;
  }
  
  private static void SetEndingOpacity(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndingOpacity = value;
  }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndPosition(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.EndPosition?.Value;
  }
  
  private static bool CmpEndPosition(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.EndPosition?.Value == value;
  }
  
  private static void SetEndPosition(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetDistanceFromText(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.DistanceFromText?.Value;
  }
  
  private static bool CmpDistanceFromText(DXO2010W.Reflection openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DistanceFromText?.Value == value;
  }
  
  private static void SetDistanceFromText(DXO2010W.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDirectionAngle(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.DirectionAngle?.Value;
  }
  
  private static bool CmpDirectionAngle(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DirectionAngle?.Value == value;
  }
  
  private static void SetDirectionAngle(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFadeDirection(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.FadeDirection?.Value;
  }
  
  private static bool CmpFadeDirection(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.FadeDirection?.Value == value;
  }
  
  private static void SetFadeDirection(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalScalingFactor(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.HorizontalScalingFactor?.Value;
  }
  
  private static bool CmpHorizontalScalingFactor(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HorizontalScalingFactor?.Value == value;
  }
  
  private static void SetHorizontalScalingFactor(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalScalingFactor(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.VerticalScalingFactor?.Value;
  }
  
  private static bool CmpVerticalScalingFactor(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.VerticalScalingFactor?.Value == value;
  }
  
  private static void SetVerticalScalingFactor(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalSkewAngle(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.HorizontalSkewAngle?.Value;
  }
  
  private static bool CmpHorizontalSkewAngle(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HorizontalSkewAngle?.Value == value;
  }
  
  private static void SetHorizontalSkewAngle(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalSkewAngle(DXO2010W.Reflection openXmlElement)
  {
    return openXmlElement.VerticalSkewAngle?.Value;
  }
  
  private static bool CmpVerticalSkewAngle(DXO2010W.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.VerticalSkewAngle?.Value == value;
  }
  
  private static void SetVerticalSkewAngle(DXO2010W.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.RectangleAlignmentKind? GetAlignment(DXO2010W.Reflection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXO2010W.Reflection openXmlElement, DMW.RectangleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXO2010W.Reflection openXmlElement, DMW.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DMW.RectangleAlignmentKind>(value);
  }
  
  public static DMW.Reflection? CreateModelElement(DXO2010W.Reflection? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010W.Reflection? openXmlElement, DMW.Reflection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlurRadius(openXmlElement, value.BlurRadius, diffs, objName))
        ok = false;
      if (!CmpStartingOpacity(openXmlElement, value.StartingOpacity, diffs, objName))
        ok = false;
      if (!CmpStartPosition(openXmlElement, value.StartPosition, diffs, objName))
        ok = false;
      if (!CmpEndingOpacity(openXmlElement, value.EndingOpacity, diffs, objName))
        ok = false;
      if (!CmpEndPosition(openXmlElement, value.EndPosition, diffs, objName))
        ok = false;
      if (!CmpDistanceFromText(openXmlElement, value.DistanceFromText, diffs, objName))
        ok = false;
      if (!CmpDirectionAngle(openXmlElement, value.DirectionAngle, diffs, objName))
        ok = false;
      if (!CmpFadeDirection(openXmlElement, value.FadeDirection, diffs, objName))
        ok = false;
      if (!CmpHorizontalScalingFactor(openXmlElement, value.HorizontalScalingFactor, diffs, objName))
        ok = false;
      if (!CmpVerticalScalingFactor(openXmlElement, value.VerticalScalingFactor, diffs, objName))
        ok = false;
      if (!CmpHorizontalSkewAngle(openXmlElement, value.HorizontalSkewAngle, diffs, objName))
        ok = false;
      if (!CmpVerticalSkewAngle(openXmlElement, value.VerticalSkewAngle, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Reflection? value)
    where OpenXmlElementType: DXO2010W.Reflection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
