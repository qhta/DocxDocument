namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic watercolor sponge effect, which simulates a watercolor texture with adjustable transparency and brush size.
/// </summary>
public interface ArtisticWatercolorSponge
{
  /// <summary>
  /// Transparency level of the watercolor sponge effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Size of the brush used in the watercolor sponge effect, influencing the coverage and texture.
  /// </summary>
  public Int32? BrushSize { get; set; }
}