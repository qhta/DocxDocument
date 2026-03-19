namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a change marked with a revision mark.
/// </summary>
public partial interface Revision : InteropObject
{
  /// <summary>
  /// The author.
  /// </summary>
  public string Author { get; }

  /// <summary>
  /// The date.
  /// </summary>
  public DateTime Date { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdRevisionType Type { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The style.
  /// </summary>
  public Style Style { get; }

  /// <summary>
  /// The format description.
  /// </summary>
  public string FormatDescription { get; }

  /// <summary>
  /// The moved range.
  /// </summary>
  public Range MovedRange { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  public Cells Cells { get; }
}
