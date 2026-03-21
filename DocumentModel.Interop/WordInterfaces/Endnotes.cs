namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Endnote objects that represents all the endnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes?view=word-pia"/>
public partial interface Endnotes : InteropObject, InteropCollection<Endnote>
{
  /// <summary>
  /// The location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.location?view=word-pia"/>
  public WdEndnoteLocation Location { get; set; }

  /// <summary>
  /// The number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.numberstyle?view=word-pia"/>
  public WdNoteNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// The starting number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// The numbering rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.numberingrule?view=word-pia"/>
  public WdNumberingRule NumberingRule { get; set; }

  /// <summary>
  /// The separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.separator?view=word-pia"/>
  public Range Separator { get; }

  /// <summary>
  /// The continuation separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.continuationseparator?view=word-pia"/>
  public Range ContinuationSeparator { get; }

  /// <summary>
  /// The continuation notice.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.continuationnotice?view=word-pia"/>
  public Range ContinuationNotice { get; }
}
