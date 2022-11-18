namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Text Wrapping.
/// </summary>
public interface ITextWrap // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  public Wrap? Type { get ; set; }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public WrapSide? Side { get ; set; }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.HorizontalAnchor? AnchorX { get ; set; }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.VerticalAnchor? AnchorY { get ; set; }
  
}
