namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tile converter from/to OpenXml.
///</summary>
public static class TileConverter
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  private static Int64? GetHorizontalOffset(DXDraw.Tile openXmlElement)
  {
    return openXmlElement?.HorizontalOffset?.Value;
  }
  
  private static bool CmpHorizontalOffset(DXDraw.Tile openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalOffset?.Value == value) return true;
    diffs?.Add(objName, "HorizontalOffset", openXmlElement?.HorizontalOffset?.Value, value);
    return false;
  }
  
  private static void SetHorizontalOffset(DXDraw.Tile openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalOffset = value;
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  private static Int64? GetVerticalOffset(DXDraw.Tile openXmlElement)
  {
    return openXmlElement?.VerticalOffset?.Value;
  }
  
  private static bool CmpVerticalOffset(DXDraw.Tile openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalOffset?.Value == value) return true;
    diffs?.Add(objName, "VerticalOffset", openXmlElement?.VerticalOffset?.Value, value);
    return false;
  }
  
  private static void SetVerticalOffset(DXDraw.Tile openXmlElement, Int64? value)
  {
    openXmlElement.VerticalOffset = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DXDraw.Tile openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXDraw.Tile openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalRatio?.Value == value) return true;
    diffs?.Add(objName, "HorizontalRatio", openXmlElement?.HorizontalRatio?.Value, value);
    return false;
  }
  
  private static void SetHorizontalRatio(DXDraw.Tile openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DXDraw.Tile openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXDraw.Tile openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalRatio?.Value == value) return true;
    diffs?.Add(objName, "VerticalRatio", openXmlElement?.VerticalRatio?.Value, value);
    return false;
  }
  
  private static void SetVerticalRatio(DXDraw.Tile openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  private static DMDraws.TileFlipKind? GetFlip(DXDraw.Tile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMDraws.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  private static bool CmpFlip(DXDraw.Tile openXmlElement, DMDraws.TileFlipKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMDraws.TileFlipKind>(openXmlElement?.Flip?.Value, value, diffs, objName);
  }
  
  private static void SetFlip(DXDraw.Tile openXmlElement, DMDraws.TileFlipKind? value)
  {
    openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMDraws.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  private static DMDraws.RectangleAlignmentKind? GetAlignment(DXDraw.Tile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXDraw.Tile openXmlElement, DMDraws.RectangleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName);
  }
  
  private static void SetAlignment(DXDraw.Tile openXmlElement, DMDraws.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.Tile? CreateModelElement(DXDraw.Tile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Tile();
      value.HorizontalOffset = GetHorizontalOffset(openXmlElement);
      value.VerticalOffset = GetVerticalOffset(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.Flip = GetFlip(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Tile? openXmlElement, DMDraws.Tile? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHorizontalOffset(openXmlElement, value.HorizontalOffset, diffs, objName))
        ok = false;
      if (!CmpVerticalOffset(openXmlElement, value.VerticalOffset, diffs, objName))
        ok = false;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName))
        ok = false;
      if (!CmpFlip(openXmlElement, value.Flip, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Tile value)
    where OpenXmlElementType: DXDraw.Tile, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Tile openXmlElement, DMDraws.Tile value)
  {
    SetHorizontalOffset(openXmlElement, value?.HorizontalOffset);
    SetVerticalOffset(openXmlElement, value?.VerticalOffset);
    SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
    SetVerticalRatio(openXmlElement, value?.VerticalRatio);
    SetFlip(openXmlElement, value?.Flip);
    SetAlignment(openXmlElement, value?.Alignment);
  }
}
