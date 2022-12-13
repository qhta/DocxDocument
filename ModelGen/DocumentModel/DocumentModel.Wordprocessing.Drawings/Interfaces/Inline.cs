namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public interface Inline
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
  public DocumentModel.HexBinaryValue? AnchorId { get ; set; }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? EditId { get ; set; }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Extent? Extent { get ; set; }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.EffectExtent? EffectExtent { get ; set; }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.DocProperties? DocProperties { get ; set; }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic { get ; set; }
  
}
