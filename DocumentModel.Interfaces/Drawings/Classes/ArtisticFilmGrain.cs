namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticFilmGrain interface.
/// </summary>
public interface ArtisticFilmGrain: IModelElement
{
  /// <summary>
  ///   trans
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   grainSize
  /// </summary>
  public Int32? GrainSize { get; set; }
}