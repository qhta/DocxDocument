namespace DocumentModel.Drawing;

/// <summary>
/// Chart Animation Build Step
/// </summary>
public enum ChartBuildStepKind
{
  /// <summary>
  /// Category.
  /// </summary>
  Category,
  
  /// <summary>
  /// Category Points.
  /// </summary>
  CategoryPoints,
  
  /// <summary>
  /// Series.
  /// </summary>
  Series,
  
  /// <summary>
  /// Series Points.
  /// </summary>
  SeriesPoints,
  
  /// <summary>
  /// All Points.
  /// </summary>
  AllPoints,
  
  /// <summary>
  /// Grid and Legend.
  /// </summary>
  GridLegend,
  
}
