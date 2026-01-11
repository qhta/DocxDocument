namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the properties for a frame in a WordprocessingML document.
///   This interface provides properties for drop caps, frame size, padding, text wrapping, positioning, alignment, height rules, and anchor locking, enabling advanced configuration and management of frames within document content.
/// </summary>
public interface FrameProperties
{
  /// <summary>
  ///   Drop cap frame location, specifying the position of the drop cap within the frame.
  /// </summary>
  public DropCapLocationKind? DropCap { get; set; }

  /// <summary>
  ///   Drop cap vertical height, specified in lines.
  /// </summary>
  public Int32? Lines { get; set; }

  /// <summary>
  ///   Width of the frame, specified as a string value (e.g., in points or percent).
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  ///   Height of the frame, specified as an unsigned integer value.
  /// </summary>
  public UInt32? Height { get; set; }

  /// <summary>
  ///   Vertical padding for the frame, specifying space above and below the frame.
  /// </summary>
  public string? VerticalSpace { get; set; }

  /// <summary>
  ///   Horizontal padding for the frame, specifying space to the left and right of the frame.
  /// </summary>
  public string? HorizontalSpace { get; set; }

  /// <summary>
  ///   Text wrapping option around the frame, specifying how text flows around the frame.
  /// </summary>
  public TextWrappingKind? Wrap { get; set; }

  /// <summary>
  ///   Horizontal positioning base for the frame, specifying the reference point for horizontal alignment.
  /// </summary>
  public HorizontalAnchorKind? HorizontalPosition { get; set; }

  /// <summary>
  ///   Vertical positioning base for the frame, specifying the reference point for vertical alignment.
  /// </summary>
  public VerticalAnchorKind? VerticalPosition { get; set; }

  /// <summary>
  ///   Absolute horizontal position of the frame, specified as a string value.
  /// </summary>
  public string? X { get; set; }

  /// <summary>
  ///   Relative horizontal position of the frame, specifying alignment relative to the horizontal anchor.
  /// </summary>
  public HorizontalAlignmentKind? XAlign { get; set; }

  /// <summary>
  ///   Absolute vertical position of the frame, specified as a string value.
  /// </summary>
  public string? Y { get; set; }

  /// <summary>
  ///   Relative vertical position of the frame, specifying alignment relative to the vertical anchor.
  /// </summary>
  public VerticalAlignmentKind? YAlign { get; set; }

  /// <summary>
  ///   Height rule for the frame, specifying how the frame height is determined.
  /// </summary>
  public HeightRuleKind? HeightType { get; set; }

  /// <summary>
  ///   Indicates whether the frame anchor is locked to the paragraph, preventing movement.
  /// </summary>
  public bool? AnchorLock { get; set; }
}