namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumberColorPosition))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IPercentageColorPosition))]
public class ValueColorMiddlePosition: IValueColorMiddlePosition
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public INumberColorPosition? NumberColorPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public IPercentageColorPosition? PercentageColorPosition
  {
    get;
    set;
  }
  
}
