namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public class Inline
{
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AnchorId
  {
    get;
    set;
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? EditId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  public Extent? Extent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public DocProperties? DocProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get;
    set;
  }
  
}
