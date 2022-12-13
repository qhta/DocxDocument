namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public interface Anchor
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  public Boolean? SimplePos { get ; set; }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  public UInt32? RelativeHeight { get ; set; }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  public Boolean? BehindDoc { get ; set; }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  public Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  public Boolean? LayoutInCell { get ; set; }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  public Boolean? AllowOverlap { get ; set; }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? EditId { get ; set; }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? AnchorId { get ; set; }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Point2DType? SimplePosition { get ; set; }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.HorizontalPosition? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.VerticalPosition? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Extent? Extent { get ; set; }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.EffectExtent? EffectExtent { get ; set; }
  
  public Boolean? WrapNone { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.WrapSquare? WrapSquare { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.WrapTight? WrapTight { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.WrapThrough? WrapThrough { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.WrapTopBottom? WrapTopBottom { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.DocProperties? DocProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  public DocumentModel.Drawings.Graphic? Graphic { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawings.RelativeWidth? RelativeWidth { get ; set; }
  
}
