namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Endnote objects that represents all the endnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes?view=word-pia"/>
public partial class Endnotes : InteropCollection<Endnote>
{
  /// <summary>
  /// Gets or sets the location of endnotes in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.location?view=word-pia"/>
  public EndnoteLocation Location { get; set; }

  /// <summary>
  /// Gets or sets the number style for endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.numberstyle?view=word-pia"/>
  public NoteNumberStyle NumberStyle { get; set; }

  /// <summary>
  /// Gets or sets the starting number for endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }

  /// <summary>
  /// Gets or sets the numbering rule for endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.numberingrule?view=word-pia"/>
  public NumberingRule NumberingRule { get; set; }

  /// <summary>
  /// Gets the endnote separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.separator?view=word-pia"/>
  public Range Separator { get; set; }

  /// <summary>
  /// Gets the endnote continuation separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.continuationseparator?view=word-pia"/>
  public Range ContinuationSeparator { get; set; }

  /// <summary>
  /// Gets the endnote continuation notice.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.continuationnotice?view=word-pia"/>
  public Range ContinuationNotice { get; set; }


  #region methods

/// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="range">Specifies the range.</param>
  /// <param name="reference">Specifies the reference.</param>
  /// <param name="text">Specifies the text.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.add?view=word-pia"/>
  public Endnote Add(Range range, object reference, object text) { throw new NotImplementedException(); }

  #endregion methods
}
