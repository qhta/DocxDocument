namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public class AreaChartExtensionListImpl: ModelElementImpl, AreaChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AreaChartExtensionListImpl(): base() {}
  
  public AreaChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<AreaChartExtension>? AreaChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
