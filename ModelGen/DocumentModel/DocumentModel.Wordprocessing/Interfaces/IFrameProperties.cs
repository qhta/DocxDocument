namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public interface IFrameProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DocumentModel.Wordprocessing.DropCapLocationKind? DropCap { get ; set; }
  
  /// <summary>
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  public System.Int32? Lines { get ; set; }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public System.String? Width { get ; set; }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public System.UInt32? Height { get ; set; }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public System.String? VerticalSpace { get ; set; }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public System.String? HorizontalSpace { get ; set; }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public DocumentModel.Wordprocessing.TextWrappingKind? Wrap { get ; set; }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchorKind? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchorKind? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Absolute Horizontal Position
  /// </summary>
  public System.String? X { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignmentKind? XAlign { get ; set; }
  
  /// <summary>
  /// Absolute Vertical Position
  /// </summary>
  public System.String? Y { get ; set; }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignmentKind? YAlign { get ; set; }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public DocumentModel.Wordprocessing.HeightRuleKind? HeightType { get ; set; }
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  public System.Boolean? AnchorLock { get ; set; }
  
}
