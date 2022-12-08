namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieChartExtensionList Class.
/// </summary>
public class PieChartExtensionListImpl: ModelElementImpl, PieChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<PieChartExtension>? PieChartExtensions
  {
    get;
    set;
  }
  
}
