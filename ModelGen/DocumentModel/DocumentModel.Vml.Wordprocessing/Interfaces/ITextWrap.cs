namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Text Wrapping.
/// </summary>
public interface ITextWrap // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  public WrapValues? Type { get ; set; }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public WrapSideValues? Side { get ; set; }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorValues? AnchorX { get ; set; }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public VerticalAnchorValues? AnchorY { get ; set; }
  
}
