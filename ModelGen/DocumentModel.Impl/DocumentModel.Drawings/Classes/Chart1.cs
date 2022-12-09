namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public class Chart1Impl: ModelElementImpl, Chart1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public ChartTitle? ChartTitle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public PlotArea1? PlotArea
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public Legend1? Legend
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
