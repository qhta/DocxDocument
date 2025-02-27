using DocumentModel.Wordprocessing.Drawings;

namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Anchor for Floating DrawingML Object.
/// </summary>
public class Anchor: ModelElement
{
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop { get; set; }

  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get; set; }

  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get; set; }

  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get; set; }

  /// <summary>
  ///   Page Positioning
  /// </summary>
  public bool? SimplePos { get; set; }

  /// <summary>
  ///   Relative Z-Ordering Position
  /// </summary>
  public UInt32? RelativeHeight { get; set; }

  /// <summary>
  ///   Display Behind Document Text
  /// </summary>
  public bool? BehindDoc { get; set; }

  /// <summary>
  ///   Lock Anchor
  /// </summary>
  public bool? Locked { get; set; }

  /// <summary>
  ///   Layout In Table Cell
  /// </summary>
  public bool? LayoutInCell { get; set; }

  /// <summary>
  ///   Hidden
  /// </summary>
  public bool? Hidden { get; set; }

  /// <summary>
  ///   Allow Objects to Overlap
  /// </summary>
  public bool? AllowOverlap { get; set; }

  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? EditId { get; set; }

  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? AnchorId { get; set; }

  /// <summary>
  ///   Simple Positioning Coordinates.
  /// </summary>
  public Point2DType? SimplePosition { get; set; }

  /// <summary>
  ///   Horizontal Positioning.
  /// </summary>
  public HorizontalPosition? HorizontalPosition { get; set; }

  /// <summary>
  ///   Vertical Positioning.
  /// </summary>
  public VerticalPosition? VerticalPosition { get; set; }

  /// <summary>
  ///   Inline Drawing Object Extents.
  /// </summary>
  public Extent? Extent { get; set; }

  /// <summary>
  ///   EffectExtent.
  /// </summary>
  public EffectExtent? EffectExtent { get; set; }

  public bool? WrapNone { get; set; }

  public WrapSquare? WrapSquare { get; set; }

  public WrapTight? WrapTight { get; set; }

  public WrapThrough? WrapThrough { get; set; }

  public WrapTopBottom? WrapTopBottom { get; set; }

  public DocProperties? DocProperties { get; set; }

  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get; set; }

  public Graphic? Graphic { get; set; }

  public RelativeWidth? RelativeWidth { get; set; }
}