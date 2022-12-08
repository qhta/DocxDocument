namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public class BarChartExtensionImpl: ModelElementImpl, BarChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredBarSeries? FilteredBarSeries
  {
    get;
    set;
  }
  
}
