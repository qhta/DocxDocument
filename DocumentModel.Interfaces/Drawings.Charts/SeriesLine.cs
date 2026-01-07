namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SeriesLine Class.
/// </summary>
public interface SeriesLine: CollectionItem
{
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}