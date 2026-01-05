namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPencilSketch interface.
/// </summary>
public interface ArtisticPencilSketch:
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   pressure
  /// </summary>
  public Int32? Pressure { get; set; }
}