namespace DocumentModel.Wordprocessing;

/// <summary>
/// Provides access to the research service feature of Microsoft Office Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research?view=word-pia"/>
public partial interface Research : IModelObject
{
  /// <summary>
  /// Gets or sets a string that specifies the favorite research service.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research.favoriteservice?view=word-pia"/>
  public string FavoriteService { get; set; }
}
