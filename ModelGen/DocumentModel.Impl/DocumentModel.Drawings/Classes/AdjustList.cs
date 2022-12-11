namespace DocumentModel.Drawings;

/// <summary>
/// Shape Adjust List.
/// </summary>
public class AdjustListImpl: ModelElementImpl, AdjustList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AdjustListImpl(): base() {}
  
  public AdjustListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Adjust>? Adjusts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
