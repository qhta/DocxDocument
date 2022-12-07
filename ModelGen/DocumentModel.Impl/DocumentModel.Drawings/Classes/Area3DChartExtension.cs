namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public class Area3DChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension>, Area3DChartExtension
{
  public FilteredAreaSeries? FilteredAreaSeries
  {
    get;
    set;
  }
  
}
