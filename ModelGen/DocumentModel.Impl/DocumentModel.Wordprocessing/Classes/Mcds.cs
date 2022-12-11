namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public class McdsImpl: ModelElementImpl, Mcds
{
  public DocumentFormat.OpenXml.Office.Word.Mcds? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Mcds?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public McdsImpl(): base() {}
  
  public McdsImpl(DocumentFormat.OpenXml.Office.Word.Mcds openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Mcd>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
