namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public class Pie3DChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>, Pie3DChartExtension
{
  public FilteredPieSeries? FilteredPieSeries
  {
    get;
    set;
  }
  
}
