namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPastelsSmooth interface.
/// </summary>
public interface ArtisticPastelsSmooth: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   scaling
  /// </summary>
  public Int32? BrushSize { get; set; }
}