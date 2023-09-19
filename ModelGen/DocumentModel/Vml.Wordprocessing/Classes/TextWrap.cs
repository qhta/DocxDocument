namespace DocumentModel.Vml.Wordprocessing;


/// <summary>
///   Text Wrapping.
/// </summary>
public partial class TextWrap
{
  
  /// <summary>
  ///   Wrapping type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Vml.Wordprocessing.WrapValues? Type { get; set; }
  
  
  /// <summary>
  ///   Wrapping side
  /// </summary>
  [SchemaAttr("side")]
  public DocumentModel.Vml.Wordprocessing.WrapSideValues? Side { get; set; }
  
  
  /// <summary>
  ///   Horizontal Positioning Base
  /// </summary>
  [SchemaAttr("anchorx")]
  public DocumentModel.Vml.Wordprocessing.HorizontalAnchorValues? AnchorX { get; set; }
  
  
  /// <summary>
  ///   Vertical Positioning Base
  /// </summary>
  [SchemaAttr("anchory")]
  public DocumentModel.Vml.Wordprocessing.VerticalAnchorValues? AnchorY { get; set; }
  
}
