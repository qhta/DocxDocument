namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic light screen effect, which simulates a grid-like light screen with adjustable transparency and grid size.
/// </summary>
public interface ArtisticLightScreen
{
  /// <summary>
  /// Gets or sets the transparency level of the light screen effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the size of the grid in the light screen effect, influencing the pattern's appearance.
  /// </summary>
  public Int32? GridSize { get; set; }
}