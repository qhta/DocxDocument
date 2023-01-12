namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tile.
/// </summary>
public static class TileConverter
{
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  public static Int64? GetHorizontalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    return openXmlElement?.HorizontalOffset?.Value;
  }
  
  public static void SetHorizontalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalOffset = value;
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public static Int64? GetVerticalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    return openXmlElement?.VerticalOffset?.Value;
  }
  
  public static void SetVerticalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalOffset = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  public static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  public static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public static DocumentModel.Drawings.TileFlipKind? GetFlip(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  public static void SetFlip(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, DocumentModel.Drawings.TileFlipKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DocumentModel.Drawings.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public static DocumentModel.Drawings.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, DocumentModel.Drawings.RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
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
