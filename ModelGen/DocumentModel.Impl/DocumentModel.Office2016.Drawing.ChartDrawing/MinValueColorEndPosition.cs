namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtremeValueColorPosition))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.INumberColorPosition))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IPercentageColorPosition))]
public class MinValueColorEndPosition: IMinValueColorEndPosition
{
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  public IExtremeValueColorPosition? ExtremeValueColorPosition
  {
    get;
    set;
  }
  
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
