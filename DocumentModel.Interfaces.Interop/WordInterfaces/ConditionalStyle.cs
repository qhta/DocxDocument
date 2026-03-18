namespace DocumentModel.Interop;

/// <summary>
/// Represents special formatting applied to specified areas of a table when the selected table is formatted with a specified table style.
/// </summary>
public interface ConditionalStyle : InteropObject
{
  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }
  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }
  /// <summary>
  /// The bottom padding.
  /// </summary>
  public float BottomPadding { get; set; }
  /// <summary>
  /// The top padding.
  /// </summary>
  public float TopPadding { get; set; }
  /// <summary>
  /// The left padding.
  /// </summary>
  public float LeftPadding { get; set; }
  /// <summary>
  /// The right padding.
  /// </summary>
  public float RightPadding { get; set; }
  /// <summary>
  /// The paragraph format.
  /// </summary>
  public ParagraphFormat ParagraphFormat { get; set; }
  /// <summary>
  /// The font.
  /// </summary>
  public Font Font { get; set; }

}
