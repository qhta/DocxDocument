namespace DocumentModel.Vml.Wordprocessing;

/// <summary>
/// Text Wrapping.
/// </summary>
public interface ITextWrap // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  public DocumentModel.Vml.Wordprocessing.HorizontalAnchorValues? AnchorX { get ; set; }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.VerticalAnchorValues? AnchorY { get ; set; }
  
}
