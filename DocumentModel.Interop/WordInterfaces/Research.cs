namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the research service feature of Microsoft Office Word.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research?view=word-pia"/>
public partial interface Research : InteropObject
{
  /// <summary>
  /// The favorite service.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research.favoriteservice?view=word-pia"/>
  public string FavoriteService { get; set; }
}
