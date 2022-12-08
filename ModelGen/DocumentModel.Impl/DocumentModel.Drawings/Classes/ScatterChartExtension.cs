namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public class ScatterChartExtensionImpl: ModelElementImpl, ScatterChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension?)_OpenXmlElement;
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
  
  public FilteredScatterSeries? FilteredScatterSeries
  {
    get;
    set;
  }
  
}
