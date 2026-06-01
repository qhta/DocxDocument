namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IChart Class.
/// </summary>
public class IChart: ModelElement
{
  /// <summary>
  ///   IChartTitle.
  /// </summary>
  public IChartTitle? IChartTitle { get; set; }

  /// <summary>
  ///   IPlotArea.
  /// </summary>
  public IPlotArea? IPlotArea { get; set; }

  /// <summary>
  ///   ILegend.
  /// </summary>
  public ILegend? ILegend { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
