namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumberColorPosition Class.
/// </summary>
public class NumberColorPosition: INumberColorPosition
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
