namespace DocumentModel.Drawing;

/// <summary>
/// Chart to Animate.
/// </summary>
public class Chart: IChart
{
  /// <summary>
  /// Series Index
  /// </summary>
  public int? SeriesIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public int? CategoryIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public ChartBuildStepValues? BuildStep
  {
    get;
    set;
  }
  
}
