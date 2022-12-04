namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public class TextWrap
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  public WrapKind? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public WrapSideKind? Side
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorKind? AnchorX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public VerticalAnchorKind? AnchorY
  {
    get;
    set;
  }
  
}
