namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticFilmGrain Class.
/// </summary>
public class ArtisticFilmGrain: ModelElement
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