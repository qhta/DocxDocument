namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public class RsidsImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Rsids>, Rsids
{
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public DocumentModel.HexWord? RsidRoot
  {
    get;
    set;
  }
  
}
