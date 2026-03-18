namespace DocumentModel.Interop;

/// <summary>
/// Represents the text frame in a Shape object. Contains the text in the text frame as well as the properties that control the margins and orientation of the text frame.
/// </summary>
public partial interface TextFrame : InteropObject
{
  /// <summary>
  /// The margin bottom.
  /// </summary>
  public float MarginBottom { get; set; }

  /// <summary>
  /// The margin left.
  /// </summary>
  public float MarginLeft { get; set; }

  /// <summary>
  /// The margin right.
  /// </summary>
  public float MarginRight { get; set; }

  /// <summary>
  /// The margin top.
  /// </summary>
  public float MarginTop { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  public Core.MsoTextOrientation Orientation { get; set; }

  /// <summary>
  /// The text range.
  /// </summary>
  public Range TextRange { get; }

  /// <summary>
  /// The containing range.
  /// </summary>
  public Range ContainingRange { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public TextFrame Next { get; set; }

  /// <summary>
  /// The previous.
  /// </summary>
  public TextFrame Previous { get; set; }

  /// <summary>
  /// The overflowing.
  /// </summary>
  public bool Overflowing { get; }

  /// <summary>
  /// The has text.
  /// </summary>
  public int HasText { get; }

  /// <summary>
  /// The auto size.
  /// </summary>
  public int AutoSize { get; set; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  public int WordWrap { get; set; }

  /// <summary>
  /// The vertical anchor.
  /// </summary>
  public Core.MsoVerticalAnchor VerticalAnchor { get; set; }

  /// <summary>
  /// The horizontal anchor.
  /// </summary>
  public Core.MsoHorizontalAnchor HorizontalAnchor { get; set; }

  /// <summary>
  /// The path format.
  /// </summary>
  public Core.MsoPathFormat PathFormat { get; set; }

  /// <summary>
  /// The warp format.
  /// </summary>
  public Core.MsoWarpFormat WarpFormat { get; set; }

  /// <summary>
  /// The column.
  /// </summary>
  public Core.TextColumn2 Column { get; }

  /// <summary>
  /// The three d.
  /// </summary>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// The no text rotation.
  /// </summary>
  public Core.MsoTriState NoTextRotation { get; set; }
}
