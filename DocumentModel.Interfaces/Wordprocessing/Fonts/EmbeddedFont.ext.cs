namespace DocumentModel.Wordprocessing;
public partial interface EmbeddedFont : IModelElement
{
  /// <summary>
  /// Retrieves the embedded font stored in the document.
  /// </summary>
  /// <returns></returns>
  public byte[]? GetEmbedFont();

}
