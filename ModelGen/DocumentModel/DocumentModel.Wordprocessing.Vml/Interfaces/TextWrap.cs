namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public partial interface TextWrap
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.WrapKind? Type { get; set; }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.WrapSideKind? Side { get; set; }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind? AnchorX { get; set; }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.VerticalAnchorKind? AnchorY { get; set; }
  
}
