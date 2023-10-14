namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Anchor for Floating DrawingML Object.
/// </summary>
public partial class Anchor
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
  public Boolean? SimplePos { get; set; }
  
  
  /// <summary>
  ///   Relative Z-Ordering Position
  /// </summary>
  public UInt32? RelativeHeight { get; set; }
  
  
  /// <summary>
  ///   Display Behind Document Text
  /// </summary>
  public Boolean? BehindDoc { get; set; }
  
  
  /// <summary>
  ///   Lock Anchor
  /// </summary>
  public Boolean? Locked { get; set; }
  
  
  /// <summary>
  ///   Layout In Table Cell
  /// </summary>
  public Boolean? LayoutInCell { get; set; }
  
  
  /// <summary>
  ///   Hidden
  /// </summary>
  public Boolean? Hidden { get; set; }
  
  
  /// <summary>
  ///   Allow Objects to Overlap
  /// </summary>
  public Boolean? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? EditId { get; set; }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? AnchorId { get; set; }
  
  
  /// <summary>
  ///   Simple Positioning Coordinates.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.SimplePosition? SimplePosition { get; set; }
  
  
  /// <summary>
  ///   Horizontal Positioning.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.HorizontalPosition? HorizontalPosition { get; set; }
  
  
  /// <summary>
  ///   Vertical Positioning.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.VerticalPosition? VerticalPosition { get; set; }
  
  
  /// <summary>
  ///   Inline Drawing Object Extents.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Extent? Extent { get; set; }
  
  
  /// <summary>
  ///   EffectExtent.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.EffectExtent? EffectExtent { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WrapNone? WrapNone { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WrapSquare? WrapSquare { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WrapTight? WrapTight { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WrapThrough? WrapThrough { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.WrapTopBottom? WrapTopBottom { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.DocProperties? DocProperties { get; set; }
  
  public DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get; set; }
  
  public DocumentModel.Drawings.Graphic? Graphic { get; set; }
  
  public DocumentModel.Wordprocessing.Drawings.RelativeWidth? RelativeWidth { get; set; }
  
  public DocumentModel.Wordprocessing.Drawings.RelativeHeight? RelativeHeight { get; set; }
  
}
