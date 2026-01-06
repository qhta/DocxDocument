namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticMarker interface.
/// </summary>
public interface ArtisticMarker
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   size
  /// </summary>
  public Int32? Size { get; set; }
}