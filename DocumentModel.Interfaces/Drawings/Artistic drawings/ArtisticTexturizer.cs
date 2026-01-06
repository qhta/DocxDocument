namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic texturizer effect, which simulates a textured appearance with adjustable transparency and scaling.
/// </summary>
public interface ArtisticTexturizer
{
  /// <summary>
  /// Gets or sets the transparency level of the texturizer effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the scaling factor for the texturizer effect, influencing the size and intensity of the texture.
  /// </summary>
  public Int32? Scaling { get; set; }
}