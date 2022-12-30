namespace DocumentModel.Drawings.Pictures;

/// <summary>
/// Picture Fill.
/// </summary>
public partial class BlipFill
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  public UInt32? Dpi { get; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawings.Blip? Blip { get; set; }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? SourceRectangle { get; set; }
  
  public DocumentModel.Drawings.Tile? Tile { get; set; }
  
  public DocumentModel.Drawings.Stretch? Stretch { get; set; }
  
}
