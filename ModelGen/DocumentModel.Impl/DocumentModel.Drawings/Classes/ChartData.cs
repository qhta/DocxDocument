namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public class ChartDataImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>, ChartData
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public ExternalData2? ExternalData
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
