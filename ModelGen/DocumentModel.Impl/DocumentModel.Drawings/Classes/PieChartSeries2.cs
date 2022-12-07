namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieChartSeries Class.
/// </summary>
public class PieChartSeries2Impl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>, PieChartSeries2
{
  /// <summary>
  /// Series Text.
  /// </summary>
  public SeriesText? SeriesText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public CategoryAxisData? CategoryAxisData
  {
    get;
    set;
  }
  
  public Values? Values
  {
    get;
    set;
  }
  
  public PieSerExtensionList? PieSerExtensionList
  {
    get;
    set;
  }
  
}
