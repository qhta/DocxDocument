namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public class ChartStringValue: IChartStringValue
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
