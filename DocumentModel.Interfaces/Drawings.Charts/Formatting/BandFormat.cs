namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the formatting for a specific band in a surface chart.
///   This interface defines the index and visual properties of the band.
/// </summary>
public interface BandFormat: CollectionItem
{
  /// <summary>
  ///   Index of the band within the collection.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Visual and shape properties for the band.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}