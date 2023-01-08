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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public static Int64? GetVerticalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalOffset(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.Tile? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
