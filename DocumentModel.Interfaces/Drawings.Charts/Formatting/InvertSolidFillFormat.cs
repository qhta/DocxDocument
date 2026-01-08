namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the settings for inverting solid fill format for negative data points.
///   This interface defines the shape properties used when the fill is inverted.
/// </summary>
public interface InvertSolidFillFormat
{
  /// <summary>
  ///   Shape properties applied when the solid fill is inverted.
  /// </summary>
  public ShapeProperties2? ShapeProperties { get; set; }
}