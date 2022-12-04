namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Anchor for Floating DrawingML Object.
/// </summary>
public class Anchor
{
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? EditId
  {
    get;
    set;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AnchorId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Simple Positioning Coordinates.
  /// </summary>
  public Boolean? SimplePosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Positioning.
  /// </summary>
  public HorizontalPosition? HorizontalPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Positioning.
  /// </summary>
  public VerticalPosition? VerticalPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inline Drawing Object Extents.
  /// </summary>
  public Extent? Extent
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectExtent.
  /// </summary>
  public EffectExtent? EffectExtent
  {
    get;
    set;
  }
  
  public WrapSquare? WrapSquare
  {
    get;
    set;
  }
  
  public WrapTight? WrapTight
  {
    get;
    set;
  }
  
  public WrapThrough? WrapThrough
  {
    get;
    set;
  }
  
  public WrapTopBottom? WrapTopBottom
  {
    get;
    set;
  }
  
  public DocProperties? DocProperties
  {
    get;
    set;
  }
  
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get;
    set;
  }
  
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get;
    set;
  }
  
  public RelativeWidth? RelativeWidth
  {
    get;
    set;
  }
  
}
