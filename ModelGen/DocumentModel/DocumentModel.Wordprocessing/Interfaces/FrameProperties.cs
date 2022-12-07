namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public interface FrameProperties
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DropCapLocationKind? DropCap { get ; set; }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public TextWrappingKind? Wrap { get ; set; }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorKind? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public VerticalAnchorKind? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public HorizontalAlignmentKind? XAlign { get ; set; }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public VerticalAlignmentKind? YAlign { get ; set; }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public HeightRuleKind? HeightType { get ; set; }
  
}
