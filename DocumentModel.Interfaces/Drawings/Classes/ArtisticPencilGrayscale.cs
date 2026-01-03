namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPencilGrayscale interface.
/// </summary>
public interface ArtisticPencilGrayscale: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   pencilSize
  /// </summary>
  public Int32? BrushSize { get; set; }
}