namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public class ScatterChartExtensionListImpl: ModelElementImpl, ScatterChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterChartExtensionListImpl(): base() {}
  
  public ScatterChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<ScatterChartExtension>? ScatterChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
