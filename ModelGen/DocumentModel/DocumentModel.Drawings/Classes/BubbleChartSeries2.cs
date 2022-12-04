namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public class BubbleChartSeries2
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
  
  public XValues? XValues
  {
    get;
    set;
  }
  
  public YValues? YValues
  {
    get;
    set;
  }
  
  public BubbleSize? BubbleSize
  {
    get;
    set;
  }
  
  public BubbleSerExtensionList? BubbleSerExtensionList
  {
    get;
    set;
  }
  
}
