namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public partial class Rsids
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public DocumentModel.HexWord? RsidRoot { get; set; }
  
  public Collection<DocumentModel.HexWord>? Items { get; set; }
  
}
