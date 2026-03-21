namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of contents in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents?view=word-pia"/>
public partial interface TableOfContents : InteropObject
{
  /// <summary>
  /// The use heading styles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.useheadingstyles?view=word-pia"/>
  public bool UseHeadingStyles { get; set; }

  /// <summary>
  /// The use fields.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.usefields?view=word-pia"/>
  public bool UseFields { get; set; }

  /// <summary>
  /// The upper heading level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.upperheadinglevel?view=word-pia"/>
  public int UpperHeadingLevel { get; set; }

  /// <summary>
  /// The lower heading level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.lowerheadinglevel?view=word-pia"/>
  public int LowerHeadingLevel { get; set; }

  /// <summary>
  /// The table id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.tableid?view=word-pia"/>
  public string TableID { get; set; }

  /// <summary>
  /// The heading styles.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.headingstyles?view=word-pia"/>
  public HeadingStyles HeadingStyles { get; }

  /// <summary>
  /// The right align page numbers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { get; set; }

  /// <summary>
  /// The include page numbers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.includepagenumbers?view=word-pia"/>
  public bool IncludePageNumbers { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The tab leader.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.tableader?view=word-pia"/>
  public WdTabLeader TabLeader { get; set; }

  /// <summary>
  /// The use hyperlinks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.usehyperlinks?view=word-pia"/>
  public bool UseHyperlinks { get; set; }

  /// <summary>
  /// The hide page numbers in web.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.hidepagenumbersinweb?view=word-pia"/>
  public bool HidePageNumbersInWeb { get; set; }
}
