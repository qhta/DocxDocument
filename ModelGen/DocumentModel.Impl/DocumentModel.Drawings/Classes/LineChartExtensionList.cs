namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public class LineChartExtensionListImpl: ModelElementImpl, LineChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<LineChartExtension>? LineChartExtensions
  {
    get;
    set;
  }
  
}
