namespace DocumentModel.Drawings;

/// <summary>
/// Tile.
/// </summary>
public class TileImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Tile>, Tile
{
  /// <summary>
  /// Tile Flipping
  /// </summary>
  public TileFlipKind? Flip
  {
    get => (TileFlipKind?)OpenXmlElement?.Flip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Flip = (DocumentFormat.OpenXml.Drawing.TileFlipValues?)value;
    }
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get => (RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues?)value;
    }
  }
  
}
