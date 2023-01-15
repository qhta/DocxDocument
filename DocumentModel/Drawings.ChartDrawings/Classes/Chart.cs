namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Chart Class.
/// </summary>
public class Chart
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