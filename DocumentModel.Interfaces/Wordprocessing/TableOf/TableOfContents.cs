namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single table of contents in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents?view=word-pia"/>
public partial interface ITableOfContents : IModelObject
{
  /// <summary>
  /// True if built-in heading styles are used to create a table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.useheadingstyles?view=word-pia"/>
  public bool UseHeadingStyles { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if Table of Contents Entry (TC) fields are used to create a table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.usefields?view=word-pia"/>
  public bool UseFields { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the starting heading level for a table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.upperheadinglevel?view=word-pia"/>
  public int UpperHeadingLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the ending heading level for a table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.lowerheadinglevel?view=word-pia"/>
  public int LowerHeadingLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a one-letter identifier that's used to build a table of contents from TOC fields.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.tableid?view=word-pia"/>
  public string TableID { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a HeadingStyles object that represents additional styles used to compile a table of contents (styles
  /// other than the Heading 1 – Heading 9 styles).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.headingstyles?view=word-pia"/>
  public IHeadingStyles HeadingStyles { get; }

  /// <summary>
  /// True if page numbers are aligned with the right margin in a table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if page numbers are included in the table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.includepagenumbers?view=word-pia"/>
  public bool IncludePageNumbers { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns or sets the character between entries and their page numbers in a table of contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.tableader?view=word-pia"/>
  public TabLeader TabLeader { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether entries in a table of contents should be formatted as hyperlinks when publishing to
  /// the Web.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.usehyperlinks?view=word-pia"/>
  public bool UseHyperlinks { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether page numbers in a table of contents should be hidden when publishing to the Web.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofcontents.hidepagenumbersinweb?view=word-pia"/>
  public bool HidePageNumbersInWeb { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
