namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties assigned to a range or selection of endnotes in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions?view=word-pia"/>
public interface IEndnoteOptions : IModelObject
{
  /// <summary>
  /// Gets or sets the location of endnotes in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.location?view=word-pia"/>
  public EndnotePosition Location { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the number style for endnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.numberstyle?view=word-pia"/>
  public NumberStyle NumberStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the starting number for endnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.startingnumber?view=word-pia"/>
  public int StartingNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the numbering rule for endnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.numberingrule?view=word-pia"/>
  public NumberingRule NumberingRule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}
