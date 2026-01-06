namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic plastic wrap effect, which simulates a plastic-wrapped appearance with adjustable transparency and smoothness.
/// </summary>
public interface ArtisticPlasticWrap
{
  /// <summary>
  /// Gets or sets the transparency level of the plastic wrap effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Gets or sets the smoothness of the plastic wrap effect, influencing the softness and clarity of the simulated plastic texture.
  /// </summary>
  public Int32? Smoothness { get; set; }
}