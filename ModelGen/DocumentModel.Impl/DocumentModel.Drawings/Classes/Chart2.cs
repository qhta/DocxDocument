namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public class Chart2Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>, Chart2
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public ChartTitle? ChartTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public PlotArea2? PlotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public Legend2? Legend
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
