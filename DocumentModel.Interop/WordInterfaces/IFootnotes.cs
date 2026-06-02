namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Footnote objects that represent all the footnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes?view=word-pia"/>
public interface IFootnotes : IInteropObject, IInteropCollection<Footnote>
{
  /// <summary>
  /// Returns or sets the position of all footnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.location?view=word-pia"/>
  public FootnoteLocation Location { get; set; }

  /// <summary>
  /// Returns or sets the number style for the footnotes in a selection, range, or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.numberstyle?view=word-pia"/>
  public NoteNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// Returns or sets the starting note number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// Returns or sets the way footnotes are numbered after page breaks or section breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.numberingrule?view=word-pia"/>
  public NumberingRule NumberingRule { get; set; }

  /// <summary>
  /// Returns a <see cref="Range"/> object that represents the footnote separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.separator?view=word-pia"/>
  public Range Separator { get; }

  /// <summary>
  /// Returns a <see cref="Range"/> object that represents the footnote continuation separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.continuationseparator?view=word-pia"/>
  public Range ContinuationSeparator { get; }

  /// <summary>
  /// Returns a <see cref="Range"/> object that represents the footnote continuation notice.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.continuationnotice?view=word-pia"/>
  public Range ContinuationNotice { get; }


  #region methods

/// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Reference">Specifies the reference.</param>
  /// <param name="Text">Specifies the text.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.add?view=word-pia"/>
  public Footnote Add(Range Range, object Reference, object Text);

  #endregion methods
}
