namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticLineDrawing interface.
/// </summary>
public interface ArtisticLineDrawing:
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   pencilSize
  /// </summary>
  public Int32? PencilSize { get; set; }
}