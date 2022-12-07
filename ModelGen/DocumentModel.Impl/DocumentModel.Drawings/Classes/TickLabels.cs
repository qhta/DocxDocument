namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TickLabels Class.
/// </summary>
public class TickLabelsImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>, TickLabels
{
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
