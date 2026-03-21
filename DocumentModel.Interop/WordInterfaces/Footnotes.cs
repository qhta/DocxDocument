namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Footnote objects that represent all the footnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes?view=word-pia"/>
public partial interface Footnotes : InteropObject, InteropCollection<Footnote>
{
  /// <summary>
  /// The location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.location?view=word-pia"/>
  public WdFootnoteLocation Location { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.numberstyle?view=word-pia"/>
  public WdNoteNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The starting number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// The numbering rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.numberingrule?view=word-pia"/>
  public WdNumberingRule NumberingRule { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.separator?view=word-pia"/>
  public Range Separator { get; }

  /// <summary>
  /// The continuation separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.continuationseparator?view=word-pia"/>
  public Range ContinuationSeparator { get; }

  /// <summary>
  /// The continuation notice.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.continuationnotice?view=word-pia"/>
  public Range ContinuationNotice { get; }
}
