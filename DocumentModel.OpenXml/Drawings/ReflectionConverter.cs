namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Reflection Effect.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  private static Int64? GetBlurRadius(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  private static bool CmpBlurRadius(DXD.Reflection openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BlurRadius?.Value == value) return true;
    diffs?.Add(objName, "BlurRadius", openXmlElement?.BlurRadius?.Value, value);
    return false;
  }
  
  private static void SetBlurRadius(DXD.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  private static Int32? GetStartOpacity(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.StartOpacity?.Value;
  }
  
  private static bool CmpStartOpacity(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartOpacity?.Value == value) return true;
    diffs?.Add(objName, "StartOpacity", openXmlElement?.StartOpacity?.Value, value);
    return false;
  }
  
  private static void SetStartOpacity(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartOpacity = value;
  }
  
  /// <summary>
  /// Start Position
  /// </summary>
  private static Int32? GetStartPosition(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.StartPosition?.Value;
  }
  
  private static bool CmpStartPosition(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartPosition?.Value == value) return true;
    diffs?.Add(objName, "StartPosition", openXmlElement?.StartPosition?.Value, value);
    return false;
  }
  
  private static void SetStartPosition(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  private static Int32? GetEndAlpha(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.EndAlpha?.Value;
  }
  
  private static bool CmpEndAlpha(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EndAlpha?.Value == value) return true;
    diffs?.Add(objName, "EndAlpha", openXmlElement?.EndAlpha?.Value, value);
    return false;
  }
  
  private static void SetEndAlpha(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndAlpha = value;
  }
  
  /// <summary>
  /// End Position
  /// </summary>
  private static Int32? GetEndPosition(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.EndPosition?.Value;
  }
  
  private static bool CmpEndPosition(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EndPosition?.Value == value) return true;
    diffs?.Add(objName, "EndPosition", openXmlElement?.EndPosition?.Value, value);
    return false;
  }
  
  private static void SetEndPosition(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  private static Int64? GetDistance(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  private static bool CmpDistance(DXD.Reflection openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Distance?.Value == value) return true;
    diffs?.Add(objName, "Distance", openXmlElement?.Distance?.Value, value);
    return false;
  }
  
  private static void SetDistance(DXD.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  private static Int32? GetDirection(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }
  
  private static bool CmpDirection(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Direction?.Value == value) return true;
    diffs?.Add(objName, "Direction", openXmlElement?.Direction?.Value, value);
    return false;
  }
  
  private static void SetDirection(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  private static Int32? GetFadeDirection(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.FadeDirection?.Value;
  }
  
  private static bool CmpFadeDirection(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FadeDirection?.Value == value) return true;
    diffs?.Add(objName, "FadeDirection", openXmlElement?.FadeDirection?.Value, value);
    return false;
  }
  
  private static void SetFadeDirection(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalRatio?.Value == value) return true;
    diffs?.Add(objName, "HorizontalRatio", openXmlElement?.HorizontalRatio?.Value, value);
    return false;
  }
  
  private static void SetHorizontalRatio(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalRatio?.Value == value) return true;
    diffs?.Add(objName, "VerticalRatio", openXmlElement?.VerticalRatio?.Value, value);
    return false;
  }
  
  private static void SetVerticalRatio(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  private static bool CmpHorizontalSkew(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalSkew?.Value == value) return true;
    diffs?.Add(objName, "HorizontalSkew", openXmlElement?.HorizontalSkew?.Value, value);
    return false;
  }
  
  private static void SetHorizontalSkew(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  private static bool CmpVerticalSkew(DXD.Reflection openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalSkew?.Value == value) return true;
    diffs?.Add(objName, "VerticalSkew", openXmlElement?.VerticalSkew?.Value, value);
    return false;
  }
  
  private static void SetVerticalSkew(DXD.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  private static DMD.RectangleAlignmentKind? GetAlignment(DXD.Reflection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXD.Reflection openXmlElement, DMD.RectangleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName);
  }
  
  private static void SetAlignment(DXD.Reflection openXmlElement, DMD.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXD.Reflection openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXD.Reflection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RotateWithShape?.Value == value) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, value);
    return false;
  }
  
  private static void SetRotateWithShape(DXD.Reflection openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  public static DocumentModel.Drawings.Reflection? CreateModelElement(DXD.Reflection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Reflection();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.StartOpacity = GetStartOpacity(openXmlElement);
      value.StartPosition = GetStartPosition(openXmlElement);
      value.EndAlpha = GetEndAlpha(openXmlElement);
      value.EndPosition = GetEndPosition(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.FadeDirection = GetFadeDirection(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Reflection? openXmlElement, DMD.Reflection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlurRadius(openXmlElement, value.BlurRadius, diffs, objName))
        ok = false;
      if (!CmpStartOpacity(openXmlElement, value.StartOpacity, diffs, objName))
        ok = false;
      if (!CmpStartPosition(openXmlElement, value.StartPosition, diffs, objName))
        ok = false;
      if (!CmpEndAlpha(openXmlElement, value.EndAlpha, diffs, objName))
        ok = false;
      if (!CmpEndPosition(openXmlElement, value.EndPosition, diffs, objName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName))
        ok = false;
      if (!CmpFadeDirection(openXmlElement, value.FadeDirection, diffs, objName))
        ok = false;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName))
        ok = false;
      if (!CmpHorizontalSkew(openXmlElement, value.HorizontalSkew, diffs, objName))
        ok = false;
      if (!CmpVerticalSkew(openXmlElement, value.VerticalSkew, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Reflection value)
    where OpenXmlElementType: DXD.Reflection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Reflection openXmlElement, DMD.Reflection value)
  {
    SetBlurRadius(openXmlElement, value?.BlurRadius);
    SetStartOpacity(openXmlElement, value?.StartOpacity);
    SetStartPosition(openXmlElement, value?.StartPosition);
    SetEndAlpha(openXmlElement, value?.EndAlpha);
    SetEndPosition(openXmlElement, value?.EndPosition);
    SetDistance(openXmlElement, value?.Distance);
    SetDirection(openXmlElement, value?.Direction);
    SetFadeDirection(openXmlElement, value?.FadeDirection);
    SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
    SetVerticalRatio(openXmlElement, value?.VerticalRatio);
    SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
    SetVerticalSkew(openXmlElement, value?.VerticalSkew);
    SetAlignment(openXmlElement, value?.Alignment);
    SetRotateWithShape(openXmlElement, value?.RotateWithShape);
  }
}
