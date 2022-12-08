namespace DocumentModel.Drawings;

/// <summary>
/// Trendline Label.
/// </summary>
public class TrendlineLabel1Impl: ModelElementImpl, TrendlineLabel1
{
  public DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout2? Layout
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public ChartText1? ChartText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public NumberingFormat1? NumberingFormat
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
  /// TextProperties.
  /// </summary>
  public TextProperties2? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
