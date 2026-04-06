using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties assigned to a range or selection of footnotes in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions?view=word-pia"/>
public interface IFootnoteOptions : IModelObject
{
  /// <summary>
  /// Returns or sets the position of all footnotes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.location?view=word-pia"/>
  public FootnotePosition Location { get; set; }
  /// <summary>
  /// Returns or sets the number style for a range or selection of footnotes in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.numberstyle?view=word-pia"/>
  public NumberStyle NumberStyle { get; set; }
  /// <summary>
  /// Returns or sets the starting note number.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }
  /// <summary>
  /// Returns or sets the way footnotes or endnotes are numbered after page breaks or section breaks.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.numberingrule?view=word-pia"/>
  public NumberingRule NumberingRule { get; set; }
  /// <summary>
  /// Returns or sets the way footnotes are laid out in columns when the section containing the reference mark has multiple columns.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.footnoteoptions.layoutcolumns?view=word-pia"/>
  public int LayoutColumns { get; set; }

}
