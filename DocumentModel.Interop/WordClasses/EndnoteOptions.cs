namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the properties assigned to a range or selection of endnotes in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions?view=word-pia"/>
public class EndnoteOptions : InteropObject
{
  /// <summary>
  /// Gets or sets the location of endnotes in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.location?view=word-pia"/>
  public EndnoteLocation Location { get; set; }
  /// <summary>
  /// Gets or sets the number style for endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.numberstyle?view=word-pia"/>
  public NoteNumberStyle NumberStyle { get; set; }
  /// <summary>
  /// Gets or sets the starting number for endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }
  /// <summary>
  /// Gets or sets the numbering rule for endnotes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnoteoptions.numberingrule?view=word-pia"/>
  public NumberingRule NumberingRule { get; set; }

}
