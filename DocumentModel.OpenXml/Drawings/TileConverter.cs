namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tile.
/// </summary>
public static class TileConverter
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  private static Int64? GetHorizontalOffset(DXDraw.Tile openXmlElement)
  {
    return openXmlElement.HorizontalOffset?.Value;
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
    return openXmlElement.VerticalOffset?.Value;
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
    return openXmlElement.HorizontalRatio?.Value;
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
    return openXmlElement.VerticalRatio?.Value;
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
  
  private static void SetAlignment(DXDraw.Tile openXmlElement, DMDraws.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(value);
  }
  
  public static DMDraws.Tile? CreateModelElement(DXDraw.Tile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Tile();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Tile? value)
    where OpenXmlElementType: DXDraw.Tile, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHorizontalOffset(openXmlElement, value?.HorizontalOffset);
      SetVerticalOffset(openXmlElement, value?.VerticalOffset);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetFlip(openXmlElement, value?.Flip);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
