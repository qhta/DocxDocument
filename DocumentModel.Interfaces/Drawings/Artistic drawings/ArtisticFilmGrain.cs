namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic film grain effect, which simulates the appearance of film grain with adjustable transparency and grain size.
/// </summary>
public interface ArtisticFilmGrain
{
  /// <summary>
  /// Gets or sets the transparency level of the film grain effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the size of the grain in the film grain effect, influencing the texture's coarseness.
  /// </summary>
  public Int32? GrainSize { get; set; }
}