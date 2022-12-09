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
    get => (Int64?)OpenXmlElement?.HorizontalOffset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalOffset = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Vertical Offset
  /// </summary>
  public Int64? VerticalOffset
  {
    get => (Int64?)OpenXmlElement?.VerticalOffset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalOffset = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio
  {
    get => (Int32?)OpenXmlElement?.HorizontalRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalRatio = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio
  {
    get => (Int32?)OpenXmlElement?.VerticalRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalRatio = (System.Int32?)value;
    }
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
