namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies information about the current paragraph with regard to text frames. Text frames are paragraphs of text in a document which are positioned in a separate region or frame in the document and can be positioned with a specific size and position relative to non-frame paragraphs in the current document.
/// </summary>
public partial class FrameProperties
{
  
  /// <summary>
  ///   Drop Cap Frame
  /// </summary>
  [SchemaAttr("w:dropCap")]
  public DocumentModel.Wordprocessing.DropCapLocationValues? DropCap { get; set; }
  
  
  /// <summary>
  ///   Drop Cap Vertical Height in Lines
  /// </summary>
  [SchemaAttr("w:lines")]
  public Int32? Lines { get; set; }
  
  
  /// <summary>
  ///   Frame Width
  /// </summary>
  [SchemaAttr("w:w")]
  public String? Width { get; set; }
  
  
  /// <summary>
  ///   Frame Height
  /// </summary>
  [SchemaAttr("w:h")]
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   Vertical Frame Padding
  /// </summary>
  [SchemaAttr("w:vSpace")]
  public String? VerticalSpace { get; set; }
  
  
  /// <summary>
  ///   Horizontal Frame Padding
  /// </summary>
  [SchemaAttr("w:hSpace")]
  public String? HorizontalSpace { get; set; }
  
  
  /// <summary>
  ///   Text Wrapping Around Frame
  /// </summary>
  [SchemaAttr("w:wrap")]
  public DocumentModel.Wordprocessing.TextWrappingValues? Wrap { get; set; }
  
  
  /// <summary>
  ///   Frame Horizontal Positioning Base
  /// </summary>
  [SchemaAttr("w:hAnchor")]
  public DocumentModel.Wordprocessing.HorizontalAnchorValues? HorizontalPosition { get; set; }
  
  
  /// <summary>
  ///   Frame Vertical Positioning Base
  /// </summary>
  [SchemaAttr("w:vAnchor")]
  public DocumentModel.Wordprocessing.VerticalAnchorValues? VerticalPosition { get; set; }
  
  
  /// <summary>
  ///   Absolute Horizontal Position
  /// </summary>
  [SchemaAttr("w:x")]
  public String? X { get; set; }
  
  
  /// <summary>
  ///   Relative Horizontal Position
  /// </summary>
  [SchemaAttr("w:xAlign")]
  public DocumentModel.Wordprocessing.HorizontalAlignmentValues? XAlign { get; set; }
  
  
  /// <summary>
  ///   Absolute Vertical Position
  /// </summary>
  [SchemaAttr("w:y")]
  public String? Y { get; set; }
  
  
  /// <summary>
  ///   Relative Vertical Position
  /// </summary>
  [SchemaAttr("w:yAlign")]
  public DocumentModel.Wordprocessing.VerticalAlignmentValues? YAlign { get; set; }
  
  
  /// <summary>
  ///   Frame Height Type
  /// </summary>
  [SchemaAttr("w:hRule")]
  public DocumentModel.Wordprocessing.HeightRuleValues? HeightType { get; set; }
  
  
  /// <summary>
  ///   Lock Frame Anchor to Paragraph
  /// </summary>
  [SchemaAttr("w:anchorLock")]
  public Boolean? AnchorLock { get; set; }
  
}
