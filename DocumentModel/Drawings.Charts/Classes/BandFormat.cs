namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Band Format.
/// </summary>
public record BandFormat
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}