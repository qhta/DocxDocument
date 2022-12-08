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
  
  public Collection<NumberDiagramInfo>? NumberDiagramInfos
  {
    get;
    set;
  }
  
}
