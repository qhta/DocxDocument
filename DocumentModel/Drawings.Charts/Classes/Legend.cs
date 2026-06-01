namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ILegend data and formatting.
/// </summary>
public class ILegend: ModelElement
{
  /// <summary>
  ///   ILegend Position.
  /// </summary>
  public LegendPositionKind? LegendPosition { get; set; }

  public Collection<ILegendEntry>? ILegendEntries { get; set; }

  public Layout? Layout { get; set; }

  public bool? Overlay { get; set; }

  public ChartShapeProperties? ChartShapeProperties { get; set; }

  public TextProperties? TextProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
