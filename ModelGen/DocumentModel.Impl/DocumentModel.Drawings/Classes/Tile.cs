namespace DocumentModel.Drawings;

/// <summary>
/// Tile.
/// </summary>
public class TileImpl: ModelElementImpl, Tile
{
  public DocumentFormat.OpenXml.Drawing.Tile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Tile?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Horizontal Offset
  /// </summary>
  public Int64? HorizontalOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public Int64? VerticalOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio
  {
    get;
    set;
  }
  
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
