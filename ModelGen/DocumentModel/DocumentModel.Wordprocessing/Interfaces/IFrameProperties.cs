namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public interface IFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DropCapLocationValues? DropCap { get ; set; }
  
  /// <summary>
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  public int? Lines { get ; set; }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public string? Width { get ; set; }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public uint? Height { get ; set; }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public string? VerticalSpace { get ; set; }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public string? HorizontalSpace { get ; set; }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public DocumentModel.Wordprocessing.TextWrappingValues? Wrap { get ; set; }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchorValues? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchorValues? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Absolute Horizontal Position
  /// </summary>
  public string? X { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignmentValues? XAlign { get ; set; }
  
  /// <summary>
  /// Absolute Vertical Position
  /// </summary>
  public string? Y { get ; set; }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignmentValues? YAlign { get ; set; }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public HeightRuleValues? HeightType { get ; set; }
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  public bool? AnchorLock { get ; set; }
  
}
