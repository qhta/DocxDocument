namespace DocumentModel.Wordprocessing;

/// <summary>
/// Listing of All Revision Save ID Values.
/// </summary>
public class RsidsImpl: ModelElementImpl, Rsids
{
  public DocumentFormat.OpenXml.Wordprocessing.Rsids? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Rsids?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Original Document Revision Save ID.
  /// </summary>
  public DocumentModel.HexWord? RsidRoot
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.HexWord>? Items
  {
    get;
    set;
  }
  
}
