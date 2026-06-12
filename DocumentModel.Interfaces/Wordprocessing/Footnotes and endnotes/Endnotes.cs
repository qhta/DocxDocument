using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Endnote objects that represents all the endnotes in a selection, range, or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes?view=word-pia"/>
public partial interface IEndnotes : IModelCollection<IEndnote>
{
  /// <summary>
  /// Gets or sets the location of endnotes in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.location?view=word-pia"/>
  public EndnotePosition Location { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the number style for endnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.numberstyle?view=word-pia"/>
  public NumberStyle NumberStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the starting number for endnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.startingnumber?view=word-pia"/>
  public int StartingNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the numbering rule for endnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.numberingrule?view=word-pia"/>
  public NumberingRule NumberingRule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets the endnote separator.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.separator?view=word-pia"/>
  public IRange Separator { get; }

  /// <summary>
  /// Gets the endnote continuation separator.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.continuationseparator?view=word-pia"/>
  public IRange ContinuationSeparator { get; }

  /// <summary>
  /// Gets the endnote continuation notice.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnotes.continuationnotice?view=word-pia"/>
  public IRange ContinuationNotice { get; }
}
