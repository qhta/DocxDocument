namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the research service feature of Microsoft Office Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research?view=word-pia"/>
public partial interface Research : InteropObject
{
  /// <summary>
  /// Returns or sets the favorite service.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research.favoriteservice?view=word-pia"/>
  public string FavoriteService { get; set; }
}
