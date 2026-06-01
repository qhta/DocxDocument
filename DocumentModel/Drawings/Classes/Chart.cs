namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IChart Ito Animate.
/// </summary>
public class IChart: ModelElement
{
  /// <summary>
  ///   ISeries IIndex
  /// </summary>
  public Int32? SeriesIndex { get; set; }

  /// <summary>
  ///   ICategory IIndex
  /// </summary>
  public Int32? CategoryIndex { get; set; }

  /// <summary>
  ///   Animation Build Step
  /// </summary>
  public ChartBuildStepKind? BuildStep { get; set; }
}
