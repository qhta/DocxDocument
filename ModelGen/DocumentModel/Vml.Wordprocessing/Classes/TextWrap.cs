namespace DocumentModel.Vml.Wordprocessing;


/// <summary>
///   Text Wrapping.
/// </summary>
public partial class TextWrap
{
  
  /// <summary>
  ///   Wrapping type
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.WrapKind? Type { get; set; }
  
  
  /// <summary>
  ///   Wrapping side
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.WrapSideKind? Side { get; set; }
  
  
  /// <summary>
  ///   Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.HorizontalAnchorKind? AnchorX { get; set; }
  
  
  /// <summary>
  ///   Vertical Positioning Base
  /// </summary>
  public DocumentModel.Vml.Wordprocessing.VerticalAnchorKind? AnchorY { get; set; }
  
}
