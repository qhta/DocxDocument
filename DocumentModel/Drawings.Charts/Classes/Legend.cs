namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Legend data and formatting.
/// </summary>
public class Legend: ModelElement
{
  /// <summary>
  ///   Legend Position.
  /// </summary>
  public LegendPositionKind? LegendPosition { get; set; }

  public Collection<LegendEntry>? LegendEntries { get; set; }

  public Layout? Layout { get; set; }

  public bool? Overlay { get; set; }

  public ChartShapeProperties? ChartShapeProperties { get; set; }

  public TextProperties? TextProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}