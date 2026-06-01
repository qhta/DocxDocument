namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the FrameProperties Class.
/// </summary>
public class FrameProperties: ModelElement
{
  /// <summary>
  ///   Drop Cap IFrame
  /// </summary>
  public DropCapLocationKind? IDropCap { get; set; }

  /// <summary>
  ///   Drop Cap Vertical Height Iin ILines
  /// </summary>
  public Int32? ILines { get; set; }

  /// <summary>
  ///   IFrame Width
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  ///   IFrame Height
  /// </summary>
  public UInt32? Height { get; set; }

  /// <summary>
  ///   Vertical IFrame Padding
  /// </summary>
  public string? VerticalSpace { get; set; }

  /// <summary>
  ///   Horizontal IFrame Padding
  /// </summary>
  public string? HorizontalSpace { get; set; }

  /// <summary>
  ///   Text Wrapping Around IFrame
  /// </summary>
  public TextWrappingKind? Wrap { get; set; }

  /// <summary>
  ///   IFrame Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorKind? HorizontalPosition { get; set; }

  /// <summary>
  ///   IFrame Vertical Positioning Base
  /// </summary>
  public VerticalAnchorKind? VerticalPosition { get; set; }

  /// <summary>
  ///   Absolute Horizontal Position
  /// </summary>
  public string? X { get; set; }

  /// <summary>
  ///   Relative Horizontal Position
  /// </summary>
  public HorizontalAlignmentKind? XAlign { get; set; }

  /// <summary>
  ///   Absolute Vertical Position
  /// </summary>
  public string? Y { get; set; }

  /// <summary>
  ///   Relative Vertical Position
  /// </summary>
  public VerticalAlignmentKind? YAlign { get; set; }

  /// <summary>
  ///   IFrame Height Type
  /// </summary>
  public HeightRuleKind? HeightType { get; set; }

  /// <summary>
  ///   Lock IFrame Anchor Ito IParagraph
  /// </summary>
  public bool? AnchorLock { get; set; }
}
