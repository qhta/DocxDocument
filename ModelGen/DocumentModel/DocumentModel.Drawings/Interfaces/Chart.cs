namespace DocumentModel.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public partial interface Chart
{
  /// <summary>
  /// Series Index
  /// </summary>
  public Int32? SeriesIndex { get; set; }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public Int32? CategoryIndex { get; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DocumentModel.Drawings.ChartBuildStepKind? BuildStep { get; set; }
  
}
