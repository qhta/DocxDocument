using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single table of figures in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures?view=word-pia"/>
public partial interface TableOfFigures : InteropObject
{
  /// <summary>
  /// Returns or sets the label that identifies the items to be included in a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// True if the caption label and caption number are included in a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.includelabel?view=word-pia"/>
  public bool IncludeLabel { get; set; }

  /// <summary>
  /// True if page numbers are aligned with the right margin in a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// True if built-in heading styles are used to create a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.useheadingstyles?view=word-pia"/>
  public bool UseHeadingStyles { get; set; }

  /// <summary>
  /// Returns or sets the ending heading level for a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.lowerheadinglevel?view=word-pia"/>
  public int LowerHeadingLevel { get; set; }

  /// <summary>
  /// Returns or sets the starting heading level for a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.upperheadinglevel?view=word-pia"/>
  public int UpperHeadingLevel { get; set; }

  /// <summary>
  /// True if page numbers are included in the table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.includepagenumbers?view=word-pia"/>
  public bool IncludePageNumbers { get; set; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// True if Table of Contents Entry (TC) fields are used to create a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.usefields?view=word-pia"/>
  public bool UseFields { get; set; }

  /// <summary>
  /// Returns or sets a one-letter identifier that's used to build a table of figures from TOC fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.tableid?view=word-pia"/>
  public string TableID { get; set; }

  /// <summary>
  /// Returns a HeadingStyles object that represents additional styles used to compile a table of figures (styles
  /// other than the Heading 1 – Heading 9 styles).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.headingstyles?view=word-pia"/>
  public HeadingStyles HeadingStyles { get; }

  /// <summary>
  /// Returns or sets the character between entries and their page numbers in a table of figures.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.tableader?view=word-pia"/>
  public TabLeader TabLeader { get; set; }

  /// <summary>
  /// Returns or sets whether entries in a table of figures should be formatted as hyperlinks when publishing to the
  /// Web.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.usehyperlinks?view=word-pia"/>
  public bool UseHyperlinks { get; set; }

  /// <summary>
  /// Returns or sets whether page numbers in a table of figures should be hidden when publishing to the Web.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.hidepagenumbersinweb?view=word-pia"/>
  public bool HidePageNumbersInWeb { get; set; }
}
