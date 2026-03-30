namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark?view=word-pia"/>
public partial interface Bookmark: IModelObject
{
  /// <summary>
  /// Selects the specified Bookmark object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.select?view=word-pia"/>
  public void Select();
}
