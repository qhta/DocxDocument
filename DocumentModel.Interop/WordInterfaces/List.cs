namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list format that's been applied to specified paragraphs in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list?view=word-pia"/>
public partial interface IList : IInteropObject
{
  /// <summary>
  /// Returns a range object that represents the portion of a document that's contained in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns a list paragraphs collection that represents all paragraphs in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// Returns whether only one list template is used for all paragraphs in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.singlelisttemplate?view=word-pia"/>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// Returns the style name for the first paragraph in the list.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.stylename?view=word-pia"/>
  public string StyleName { get; }
}
