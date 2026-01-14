namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic texturizer effect, which simulates a textured appearance with adjustable transparency and scaling.
/// </summary>
public class ArtisticTexturizer: ModelElement
{
  /// <summary>
  /// Transparency level of the texturizer effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Scaling factor for the texturizer effect, influencing the size and intensity of the texture.
  /// </summary>
  public Int32? Scaling { get; set; }
}