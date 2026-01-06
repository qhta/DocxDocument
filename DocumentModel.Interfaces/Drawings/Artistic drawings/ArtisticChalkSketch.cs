namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticChalkSketch interface.
/// </summary>
public interface ArtisticChalkSketch
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