namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Chart Class.
/// </summary>
public class Chart: ModelElement
{
  /// <summary>
  ///   ChartTitle.
  /// </summary>
  public ChartTitle? ChartTitle { get; set; }

  /// <summary>
  ///   PlotArea.
  /// </summary>
  public PlotArea? PlotArea { get; set; }

  /// <summary>
  ///   Legend.
  /// </summary>
  public Legend? Legend { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}