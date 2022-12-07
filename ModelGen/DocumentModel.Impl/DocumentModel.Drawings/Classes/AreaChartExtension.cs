namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public class AreaChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension>, AreaChartExtension
{
  public FilteredAreaSeries? FilteredAreaSeries
  {
    get;
    set;
  }
  
}
