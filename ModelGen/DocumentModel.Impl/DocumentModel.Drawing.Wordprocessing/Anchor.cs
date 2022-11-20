namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IDocProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.INonVisualGraphicFrameDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.ISimplePosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IExtent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IEffectExtent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IHorizontalPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IVerticalPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapNone))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapSquare))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapThrough))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapTight))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapTopBottom))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.Drawing.IRelativeWidth))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.Drawing.IRelativeHeight))]
public class Anchor: IAnchor
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public uint? DistanceFromTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public uint? DistanceFromBottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public uint? DistanceFromLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public uint? DistanceFromRight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Positioning
  /// </summary>
  public bool? SimplePos
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relative Z-Ordering Position
  /// </summary>
  public uint? RelativeHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Display Behind Document Text
  /// </summary>
  public bool? BehindDoc
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lock Anchor
  /// </summary>
  public bool? Locked
  {
    get;
    set;
  }
  
  /// <summary>
  /// Layout In Table Cell
  /// </summary>
  public bool? LayoutInCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Allow Objects to Overlap
  /// </summary>
  public bool? AllowOverlap
  {
    get;
    set;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? EditId
  {
    get;
    set;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? AnchorId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public ISimplePosition? SimplePosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public IHorizontalPosition? HorizontalPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public IVerticalPosition? VerticalPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IExtent? Extent
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public IEffectExtent? EffectExtent
  {
    get;
    set;
  }
  
}
