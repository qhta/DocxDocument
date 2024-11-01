namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Wrapping.
/// </summary>
public class TextWrap: ModelElement
{
  /// <summary>
  ///   Wrapping type
  /// </summary>
  public WrapKind? Type { get; set; }

  /// <summary>
  ///   Wrapping side
  /// </summary>
  public WrapSideKind? Side { get; set; }

  /// <summary>
  ///   Horizontal Positioning Base
  /// </summary>
  public HorizontalAnchorKind? AnchorX { get; set; }

  /// <summary>
  ///   Vertical Positioning Base
  /// </summary>
  public VerticalAnchorKind? AnchorY { get; set; }
}