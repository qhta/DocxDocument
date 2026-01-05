namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPaintStrokes interface.
/// </summary>
public interface ArtisticPaintStrokes:
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   intensity
  /// </summary>
  public Int32? Intensity { get; set; }
}