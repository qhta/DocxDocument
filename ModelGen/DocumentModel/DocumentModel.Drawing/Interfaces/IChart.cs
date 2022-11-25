namespace DocumentModel.Drawing;

/// <summary>
/// Chart to Animate.
/// </summary>
public interface IChart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Series Index
  /// </summary>
  public System.Int32? SeriesIndex { get ; set; }
  
  /// <summary>
  /// Category Index
  /// </summary>
  public System.Int32? CategoryIndex { get ; set; }
  
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public DocumentModel.Drawing.ChartBuildStepKind? BuildStep { get ; set; }
  
}
