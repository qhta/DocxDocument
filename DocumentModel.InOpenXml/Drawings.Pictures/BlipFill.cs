namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Picture Fill.
/// </summary>
public partial class BlipFill : ModelElement<DXDP.BlipFill>
{
  /// <summary>
  ///   DPI Setting
  /// </summary>
  public UInt32? Dpi { get; set; }
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public bool? RotateWithShape { get; set; }
  /// <summary>
  ///   Blip.
  /// </summary>
  public Blip? Blip { get; set; }
  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  public RelativeRectangleType? SourceRectangle { get; set; }
  public Tile? Tile { get; set; }
  public Stretch? Stretch { get; set; }
}