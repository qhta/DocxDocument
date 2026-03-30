using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Footnote objects that represent all the footnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes?view=word-pia"/>
public partial interface IFootnotes : IModelCollection<IFootnote>
{
  /// <summary>
  /// Returns or sets the position of all footnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.location?view=word-pia"/>
  public FootnotePosition Location { get; set; }

  /// <summary>
  /// Returns or sets the number style for the footnotes in a selection, range, or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.numberstyle?view=word-pia"/>
  public NumberStyle NumberStyle { get; set; }

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
  /// Returns a <see cref="IRange"/> object that represents the footnote separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.separator?view=word-pia"/>
  public IRange Separator { get; }

  /// <summary>
  /// Returns a <see cref="IRange"/> object that represents the footnote continuation separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.continuationseparator?view=word-pia"/>
  public IRange ContinuationSeparator { get; }

  /// <summary>
  /// Returns a <see cref="IRange"/> object that represents the footnote continuation notice.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnotes.continuationnotice?view=word-pia"/>
  public IRange ContinuationNotice { get; }
}
