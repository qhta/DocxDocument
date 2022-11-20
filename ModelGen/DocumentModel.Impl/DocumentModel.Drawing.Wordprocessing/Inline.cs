namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphic))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IDocProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.INonVisualGraphicFrameDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IExtent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IEffectExtent))]
public class Inline: IInline
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
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? AnchorId
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
  /// Drawing Object Size.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IExtent? Extent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public IEffectExtent? EffectExtent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public IDocProperties? DocProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public IGraphic? Graphic
  {
    get;
    set;
  }
  
}
