using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single index.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index?view=word-pia"/>
public partial interface Index : IModelObject
{
  /// <summary>
  /// Returns or sets the character that separates topic headings and page numbers in an index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.headingseparator?view=word-pia"/>
  public HeadingSeparator HeadingSeparator { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether page numbers are right-aligned in the index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.rightalignpagenumbers?view=word-pia"/>
  public bool RightAlignPageNumbers { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the type of index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.type?view=word-pia"/>
  public IndexType Type { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the number of columns in the index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.numberofcolumns?view=word-pia"/>
  public int NumberOfColumns { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a range object that represents the portion of the document included in the index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns or sets the tab leader character between entries and page numbers in the index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.tableader?view=word-pia"/>
  public TabLeader TabLeader { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether accented letters are treated separately in index sorting.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.accentedletters?view=word-pia"/>
  public bool AccentedLetters { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets how index entries are sorted.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.sortby?view=word-pia"/>
  public IndexSortBy SortBy { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the type of index filter to apply.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.filter?view=word-pia"/>
  public IndexFilter Filter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the language used for sorting the index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.index.indexlanguage?view=word-pia"/>
  public LanguageID IndexLanguage { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
