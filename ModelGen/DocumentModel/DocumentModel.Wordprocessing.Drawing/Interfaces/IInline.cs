namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public interface IInline // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? AnchorId { get ; set; }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? EditId { get ; set; }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public IEffectExtent? EffectExtent { get ; set; }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public IDocProperties? DocProperties { get ; set; }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawing.IGraphic? Graphic { get ; set; }
  
}
