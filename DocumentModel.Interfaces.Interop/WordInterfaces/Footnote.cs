namespace DocumentModel.Interop;

/// <summary>
/// Represents a footnote positioned at the bottom of the page or beneath text. The Footnote object is a member of the Footnotes collection. The Footnotes collection represents the footnotes in a selection, range, or document.
/// </summary>
public partial interface Footnote : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The reference.
  /// </summary>
  public Range Reference { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
}
