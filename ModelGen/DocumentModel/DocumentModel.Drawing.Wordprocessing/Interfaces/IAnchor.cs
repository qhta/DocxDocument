namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public interface IAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public System.UInt32? DistanceFromTop { get ; set; }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public System.UInt32? DistanceFromBottom { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public System.UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public System.UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  public System.Boolean? SimplePos { get ; set; }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  public System.UInt32? RelativeHeight { get ; set; }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  public System.Boolean? BehindDoc { get ; set; }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  public System.Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  public System.Boolean? LayoutInCell { get ; set; }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  public System.Boolean? AllowOverlap { get ; set; }
  
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
  public DocumentModel.Drawing.Wordprocessing.IPoint2DType? SimplePosition { get ; set; }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IHorizontalPosition? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IVerticalPosition? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IExtent? Extent { get ; set; }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IEffectExtent? EffectExtent { get ; set; }
  
  public System.Boolean? WrapNone { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.IWrapSquare? WrapSquare { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.IWrapTight? WrapTight { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.IWrapThrough? WrapThrough { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.IWrapTopBottom? WrapTopBottom { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.IDocProperties? DocProperties { get ; set; }
  
  public DocumentModel.Drawing.Wordprocessing.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
  public DocumentModel.Office2010.Word.Drawing.IRelativeWidth? RelativeWidth { get ; set; }
  
}
