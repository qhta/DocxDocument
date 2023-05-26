namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tile.
/// </summary>
public static class TileConverter
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  private static Int64? GetHorizontalOffset(DXD.Tile openXmlElement)
  {
    return openXmlElement?.HorizontalOffset?.Value;
  }
  
  private static bool CmpHorizontalOffset(DXD.Tile openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalOffset?.Value == value) return true;
    diffs?.Add(objName, "HorizontalOffset", openXmlElement?.HorizontalOffset?.Value, value);
    return false;
  }
  
  private static void SetHorizontalOffset(DXD.Tile openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalOffset = value;
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  private static Int64? GetVerticalOffset(DXD.Tile openXmlElement)
  {
    return openXmlElement?.VerticalOffset?.Value;
  }
  
  private static bool CmpVerticalOffset(DXD.Tile openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalOffset?.Value == value) return true;
    diffs?.Add(objName, "VerticalOffset", openXmlElement?.VerticalOffset?.Value, value);
    return false;
  }
  
  private static void SetVerticalOffset(DXD.Tile openXmlElement, Int64? value)
  {
    openXmlElement.VerticalOffset = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DXD.Tile openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXD.Tile openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalRatio?.Value == value) return true;
    diffs?.Add(objName, "HorizontalRatio", openXmlElement?.HorizontalRatio?.Value, value);
    return false;
  }
  
  private static void SetHorizontalRatio(DXD.Tile openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DXD.Tile openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXD.Tile openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalRatio?.Value == value) return true;
    diffs?.Add(objName, "VerticalRatio", openXmlElement?.VerticalRatio?.Value, value);
    return false;
  }
  
  private static void SetVerticalRatio(DXD.Tile openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  private static DMD.TileFlipKind? GetFlip(DXD.Tile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  private static bool CmpFlip(DXD.Tile openXmlElement, DMD.TileFlipKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(openXmlElement?.Flip?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFlip(DXD.Tile openXmlElement, DMD.TileFlipKind? value)
  {
    openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  private static DMD.RectangleAlignmentKind? GetAlignment(DXD.Tile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXD.Tile openXmlElement, DMD.RectangleAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXD.Tile openXmlElement, DMD.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.Tile? CreateModelElement(DXD.Tile? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.Tile? openXmlElement, DMD.Tile? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHorizontalOffset(openXmlElement, value.HorizontalOffset, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalOffset(openXmlElement, value.VerticalOffset, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName, propName))
        ok = false;
      if (!CmpFlip(openXmlElement, value.Flip, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Tile value)
    where OpenXmlElementType: DXD.Tile, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Tile openXmlElement, DMD.Tile value)
  {
    SetHorizontalOffset(openXmlElement, value?.HorizontalOffset);
    SetVerticalOffset(openXmlElement, value?.VerticalOffset);
    SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
    SetVerticalRatio(openXmlElement, value?.VerticalRatio);
    SetFlip(openXmlElement, value?.Flip);
    SetAlignment(openXmlElement, value?.Alignment);
  }
}
