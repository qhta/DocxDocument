namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list format that's been applied to specified paragraphs in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list?view=word-pia"/>
public partial interface List : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The list paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// The single list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// The style name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.stylename?view=word-pia"/>
  public string StyleName { get; }
}
