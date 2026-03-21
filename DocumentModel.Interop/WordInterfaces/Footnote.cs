namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a footnote positioned at the bottom of the page or beneath text. The Footnote object is a member of the Footnotes collection. The Footnotes collection represents the footnotes in a selection, range, or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote?view=word-pia"/>
public partial interface Footnote : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The reference.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.reference?view=word-pia"/>
  public Range Reference { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnote.index?view=word-pia"/>
  public int Index { get; }
}
