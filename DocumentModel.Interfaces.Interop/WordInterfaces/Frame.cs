namespace DocumentModel.Interop;

/// <summary>
/// Represents a frame in a selection, range, or document.
/// </summary>
public partial interface Frame : InteropObject
{
  /// <summary>
  /// The height rule.
  /// </summary>
  public WdFrameSizeRule HeightRule { get; set; }

  /// <summary>
  /// The width rule.
  /// </summary>
  public WdFrameSizeRule WidthRule { get; set; }

  /// <summary>
  /// The horizontal distance from text.
  /// </summary>
  public float HorizontalDistanceFromText { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The horizontal position.
  /// </summary>
  public float HorizontalPosition { get; set; }

  /// <summary>
  /// The lock anchor.
  /// </summary>
  public bool LockAnchor { get; set; }

  /// <summary>
  /// The relative horizontal position.
  /// </summary>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// The relative vertical position.
  /// </summary>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// The vertical distance from text.
  /// </summary>
  public float VerticalDistanceFromText { get; set; }

  /// <summary>
  /// The vertical position.
  /// </summary>
  public float VerticalPosition { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The text wrap.
  /// </summary>
  public bool TextWrap { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
}
