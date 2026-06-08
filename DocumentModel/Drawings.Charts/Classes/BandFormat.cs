namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Band Format.
/// </summary>
public class BandFormat: ModelElement
{
  /// <summary>
  ///   IIndex.
  /// </summary>
  public UInt32? IIndex { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}
