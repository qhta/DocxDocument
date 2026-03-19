namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the research service feature of Microsoft Office Word.
/// </summary>
public partial interface Research : InteropObject
{
  /// <summary>
  /// The favorite service.
  /// </summary>
  public string FavoriteService { get; set; }
}
