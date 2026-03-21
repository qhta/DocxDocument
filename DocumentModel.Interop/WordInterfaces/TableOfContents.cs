namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of contents in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents?view=word-pia"/>
public partial interface TableOfContents : InteropObject
{
  /// <summary>
  /// Returns or sets whether use heading styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.useheadingstyles?view=word-pia"/>
  public bool UseHeadingStyles { get; set; }

  /// <summary>
  /// Returns or sets whether use fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.usefields?view=word-pia"/>
  public bool UseFields { get; set; }

  /// <summary>
  /// Returns or sets the upper heading level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.upperheadinglevel?view=word-pia"/>
  public int UpperHeadingLevel { get; set; }

  /// <summary>
  /// Returns or sets the lower heading level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.lowerheadinglevel?view=word-pia"/>
  public int LowerHeadingLevel { get; set; }

  /// <summary>
  /// Returns or sets the table i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.tableid?view=word-pia"/>
  public string TableID { get; set; }

  /// <summary>
  /// Returns the heading styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.headingstyles?view=word-pia"/>
  public HeadingStyles HeadingStyles { get; }

  /// <summary>
  /// Returns or sets whether right align page numbers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// Returns or sets whether include page numbers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.includepagenumbers?view=word-pia"/>
  public bool IncludePageNumbers { get; set; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets the tab leader.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// Returns or sets whether use hyperlinks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.usehyperlinks?view=word-pia"/>
  public bool UseHyperlinks { get; set; }

  /// <summary>
  /// Returns or sets whether hide page numbers in web.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.hidepagenumbersinweb?view=word-pia"/>
  public bool HidePageNumbersInWeb { get; set; }
}
