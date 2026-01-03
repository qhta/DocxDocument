namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticFilmGrain interface.
/// </summary>
public interface ArtisticFilmGrain: IModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  /// <summary>
  ///   grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? GrainSize { get; set; }
}