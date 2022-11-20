namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PercentageColorPosition Class.
/// </summary>
public class PercentageColorPosition: IPercentageColorPosition
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Val
  {
    get;
    set;
  }
  
}
