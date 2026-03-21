namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the properties assigned to a range or selection of footnotes in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions?view=word-pia"/>
public interface FootnoteOptions : InteropObject
{
  /// <summary>
  /// The location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.location?view=word-pia"/>
  public WdFootnoteLocation Location { get; set; }
  /// <summary>
  /// The number style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.numberstyle?view=word-pia"/>
  public WdNoteNumberStyle NumberStyle { get; set; }
  /// <summary>
  /// The starting number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }
  /// <summary>
  /// The numbering rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.numberingrule?view=word-pia"/>
  public WdNumberingRule NumberingRule { get; set; }
  /// <summary>
  /// The layout columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.layoutcolumns?view=word-pia"/>
  public int LayoutColumns { get; set; }

}
