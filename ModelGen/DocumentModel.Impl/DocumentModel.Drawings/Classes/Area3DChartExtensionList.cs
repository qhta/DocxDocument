namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public class Area3DChartExtensionListImpl: ModelElementImpl, Area3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Area3DChartExtensionListImpl(): base() {}
  
  public Area3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Area3DChartExtension>? Area3DChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
