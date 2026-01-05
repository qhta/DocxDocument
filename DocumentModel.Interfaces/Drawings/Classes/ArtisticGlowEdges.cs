namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticGlowEdges interface.
/// </summary>
public interface ArtisticGlowEdges:
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   smoothness
  /// </summary>
  public Int32? Smoothness { get; set; }
}