namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Trendline Label.
/// </summary>
public class TrendlineLabelImpl: ModelElementImpl, TrendlineLabel
{
  public DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TrendlineLabelImpl(): base() {}
  
  public TrendlineLabelImpl(DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.Layout? Layout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartText? ChartText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
