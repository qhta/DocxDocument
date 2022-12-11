namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public class NumberDiagramInfoListImpl: ModelElementImpl, NumberDiagramInfoList
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberDiagramInfoListImpl(): base() {}
  
  public NumberDiagramInfoListImpl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<NumberDiagramInfo>? NumberDiagramInfos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
