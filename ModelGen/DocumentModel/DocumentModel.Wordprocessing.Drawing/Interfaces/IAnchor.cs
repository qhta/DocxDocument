namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public interface IAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.IHexBinaryValue? EditId { get ; set; }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? AnchorId { get ; set; }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public IPoint2DType? SimplePosition { get ; set; }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public IHorizontalPosition? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public IVerticalPosition? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public IEffectExtent? EffectExtent { get ; set; }
  
  public Boolean? WrapNone { get ; set; }
  
  public IWrapSquare? WrapSquare { get ; set; }
  
  public IWrapTight? WrapTight { get ; set; }
  
  public IWrapThrough? WrapThrough { get ; set; }
  
  public IWrapTopBottom? WrapTopBottom { get ; set; }
  
  public IDocProperties? DocProperties { get ; set; }
  
  public INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
  public IRelativeWidth? RelativeWidth { get ; set; }
  
}
