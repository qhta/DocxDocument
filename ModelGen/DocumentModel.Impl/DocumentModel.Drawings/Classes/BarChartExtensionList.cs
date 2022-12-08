namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public class BarChartExtensionListImpl: ModelElementImpl, BarChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<BarChartExtension>? BarChartExtensions
  {
    get;
    set;
  }
  
}
