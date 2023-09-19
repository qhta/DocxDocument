namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Anchor for Floating DrawingML Object.
/// </summary>
public partial class Anchor
{
  
  /// <summary>
  ///   Distance From Text on Top Edge
  /// </summary>
  [SchemaAttr("distT")]
  public UInt32? DistanceFromTop { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Bottom Edge
  /// </summary>
  [SchemaAttr("distB")]
  public UInt32? DistanceFromBottom { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Left Edge
  /// </summary>
  [SchemaAttr("distL")]
  public UInt32? DistanceFromLeft { get; set; }
  
  
  /// <summary>
  ///   Distance From Text on Right Edge
  /// </summary>
  [SchemaAttr("distR")]
  public UInt32? DistanceFromRight { get; set; }
  
  
  /// <summary>
  ///   Page Positioning
  /// </summary>
  [SchemaAttr("simplePos")]
  public Boolean? SimplePos { get; set; }
  
  
  /// <summary>
  ///   Relative Z-Ordering Position
  /// </summary>
  [SchemaAttr("relativeHeight")]
  public UInt32? RelativeHeight { get; set; }
  
  
  /// <summary>
  ///   Display Behind Document Text
  /// </summary>
  [SchemaAttr("behindDoc")]
  public Boolean? BehindDoc { get; set; }
  
  
  /// <summary>
  ///   Lock Anchor
  /// </summary>
  [SchemaAttr("locked")]
  public Boolean? Locked { get; set; }
  
  
  /// <summary>
  ///   Layout In Table Cell
  /// </summary>
  [SchemaAttr("layoutInCell")]
  public Boolean? LayoutInCell { get; set; }
  
  
  /// <summary>
  ///   Hidden
  /// </summary>
  [SchemaAttr("hidden")]
  public Boolean? Hidden { get; set; }
  
  
  /// <summary>
  ///   Allow Objects to Overlap
  /// </summary>
  [SchemaAttr("allowOverlap")]
  public Boolean? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   editId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("wp14:editId")]
  public DocumentModel.HexBinaryValue? EditId { get; set; }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("wp14:anchorId")]
  public DocumentModel.HexBinaryValue? AnchorId { get; set; }
  
  
  /// <summary>
  ///   Simple Positioning Coordinates.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Point2DType? SimplePosition { get; set; }
  
  
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
  
  public Boolean? WrapNone { get; set; }
  
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
