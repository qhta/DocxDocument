namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tile.
/// </summary>
public static class TileConverter
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  private static Int64? GetHorizontalOffset(DocumentFormat.OpenXml.Drawing.Tile openXmlElement)
  {
    return openXmlElement.HorizontalOffset?.Value;
  }
  
  private static void SetHorizontalOffset(DocumentFormat.OpenXml.Drawing.Tile openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalOffset = value;
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  private static Int64? GetVerticalOffset(DocumentFormat.OpenXml.Drawing.Tile openXmlElement)
  {
    return openXmlElement.VerticalOffset?.Value;
  }
  
  private static void SetVerticalOffset(DocumentFormat.OpenXml.Drawing.Tile openXmlElement, Int64? value)
  {
    openXmlElement.VerticalOffset = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Tile openXmlElement)
  {
    return openXmlElement.HorizontalRatio?.Value;
  }
  
  private static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Tile openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.Tile openXmlElement)
  {
    return openXmlElement.VerticalRatio?.Value;
  }
  
  private static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.Tile openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  private static DocumentModel.Drawings.TileFlipKind? GetFlip(DocumentFormat.OpenXml.Drawing.Tile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  private static void SetFlip(DocumentFormat.OpenXml.Drawing.Tile openXmlElement, DocumentModel.Drawings.TileFlipKind? value)
  {
    openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  private static DocumentModel.Drawings.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.Tile openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Drawing.Tile openXmlElement, DocumentModel.Drawings.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.Tile? CreateModelElement(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Tile? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Tile, new()
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
