namespace DocumentModel.Drawing;

/// <summary>
/// Chart to Animate.
/// </summary>
public interface IChart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Series Index
  /// </summary>
  public Int32? SeriesIndex { get ; set; }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public Int32? CategoryIndex { get ; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public ChartBuildStepKind? BuildStep { get ; set; }
  
}
