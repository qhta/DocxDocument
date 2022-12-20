namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public partial interface FrameProperties
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DocumentModel.Wordprocessing.DropCapLocationKind? DropCap { get; set; }
  
  /// <summary>
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  public Int32? Lines { get; set; }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public String? Width { get; set; }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public UInt32? Height { get; set; }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public String? VerticalSpace { get; set; }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public String? HorizontalSpace { get; set; }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public DocumentModel.Wordprocessing.TextWrappingKind? Wrap { get; set; }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchorKind? HorizontalPosition { get; set; }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchorKind? VerticalPosition { get; set; }
  
  /// <summary>
  /// Absolute Horizontal Position
  /// </summary>
  public String? X { get; set; }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignmentKind? XAlign { get; set; }
  
  /// <summary>
  /// Absolute Vertical Position
  /// </summary>
  public String? Y { get; set; }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignmentKind? YAlign { get; set; }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public DocumentModel.Wordprocessing.HeightRuleKind? HeightType { get; set; }
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  public Boolean? AnchorLock { get; set; }
  
}
