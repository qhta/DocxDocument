namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public class Bar3DChartExtensionImpl: ModelElementImpl, Bar3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension?)_OpenXmlElement;
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
