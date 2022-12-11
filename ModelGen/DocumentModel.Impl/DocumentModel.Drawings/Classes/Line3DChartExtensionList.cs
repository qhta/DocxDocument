namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public class Line3DChartExtensionListImpl: ModelElementImpl, Line3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Line3DChartExtensionListImpl(): base() {}
  
  public Line3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Line3DChartExtension>? Line3DChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
