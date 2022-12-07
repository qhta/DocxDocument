namespace DocumentModel.Drawings;

/// <summary>
/// Chart to Animate.
/// </summary>
public interface Chart3
{
  /// <summary>
  /// Animation Build Step
  /// </summary>
  public ChartBuildStepKind? BuildStep { get ; set; }
  
}
