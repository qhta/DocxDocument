namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of figures in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures?view=word-pia"/>
public partial interface TableOfFigures : InteropObject
{
  /// <summary>
  /// Returns or sets the caption.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Returns or sets whether include label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.includelabel?view=word-pia"/>
  public bool IncludeLabel { get; set; }

  /// <summary>
  /// Returns or sets whether right align page numbers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// Returns or sets whether use heading styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.useheadingstyles?view=word-pia"/>
  public bool UseHeadingStyles { get; set; }

  /// <summary>
  /// Returns or sets the lower heading level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.lowerheadinglevel?view=word-pia"/>
  public int LowerHeadingLevel { get; set; }

  /// <summary>
  /// Returns or sets the upper heading level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.upperheadinglevel?view=word-pia"/>
  public int UpperHeadingLevel { get; set; }

  /// <summary>
  /// Returns or sets whether include page numbers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.includepagenumbers?view=word-pia"/>
  public bool IncludePageNumbers { get; set; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets whether use fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.usefields?view=word-pia"/>
  public bool UseFields { get; set; }

  /// <summary>
  /// Returns or sets the table i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.tableid?view=word-pia"/>
  public string TableID { get; set; }

  /// <summary>
  /// Returns the heading styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.headingstyles?view=word-pia"/>
  public HeadingStyles HeadingStyles { get; }

  /// <summary>
  /// Returns or sets the tab leader.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// Returns or sets whether use hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.usehyperlinks?view=word-pia"/>
  public bool UseHyperlinks { get; set; }

  /// <summary>
  /// Returns or sets whether hide page numbers in web.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableoffigures.hidepagenumbersinweb?view=word-pia"/>
  public bool HidePageNumbersInWeb { get; set; }
}
