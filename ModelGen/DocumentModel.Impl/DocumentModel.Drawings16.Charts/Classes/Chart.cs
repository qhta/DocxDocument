namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public class ChartImpl: ModelElementImpl, Chart
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartImpl(): base() {}
  
  public ChartImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ChartTitle? ChartTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PlotArea? PlotArea
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Legend? Legend
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
