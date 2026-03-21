namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the properties assigned to a range or selection of endnotes in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions?view=word-pia"/>
public interface EndnoteOptions : InteropObject
{
  /// <summary>
  /// The location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.location?view=word-pia"/>
  public WdEndnoteLocation Location { get; set; }
  /// <summary>
  /// The number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.numberstyle?view=word-pia"/>
  public WdNoteNumberStyle NumberStyle { get; set; }
  /// <summary>
  /// The starting number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }
  /// <summary>
  /// The numbering rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.numberingrule?view=word-pia"/>
  public WdNumberingRule NumberingRule { get; set; }

}
