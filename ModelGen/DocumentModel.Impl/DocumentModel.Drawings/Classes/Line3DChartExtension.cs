namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public class Line3DChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>, Line3DChartExtension
{
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get;
    set;
  }
  
}
