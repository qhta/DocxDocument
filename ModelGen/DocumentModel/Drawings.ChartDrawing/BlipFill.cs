namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Picture Fill.
/// </summary>
public partial class BlipFill
{
  
  /// <summary>
  ///   DPI Setting
  /// </summary>
  public UInt32? Dpi { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
  
  /// <summary>
  ///   Blip.
  /// </summary>
  public DMD.Blip? Blip { get; set; }
  
  
  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  public DMD.SourceRectangle? SourceRectangle { get; set; }
  
  public DMD.Tile? Tile { get; set; }
  
  public DMD.Stretch? Stretch { get; set; }
  
}
