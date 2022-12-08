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
  
  public Collection<AreaChartExtension>? AreaChartExtensions
  {
    get;
    set;
  }
  
}
