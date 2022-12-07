namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public class ScatterChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension>, ScatterChartExtension
{
  public FilteredScatterSeries? FilteredScatterSeries
  {
    get;
    set;
  }
  
}
