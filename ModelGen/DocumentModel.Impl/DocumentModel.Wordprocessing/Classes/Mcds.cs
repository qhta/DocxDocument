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
  
  public Collection<Mcd>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
