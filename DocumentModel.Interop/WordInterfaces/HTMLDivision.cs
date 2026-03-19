namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single HTML division that can be added to a Web document.
/// </summary>
public partial interface HTMLDivision : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; }

  /// <summary>
  /// The left indent.
  /// </summary>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The right indent.
  /// </summary>
  public float RightIndent { get; set; }

  /// <summary>
  /// The space before.
  /// </summary>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// The space after.
  /// </summary>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  public HTMLDivisions HTMLDivisions { get; }
}
