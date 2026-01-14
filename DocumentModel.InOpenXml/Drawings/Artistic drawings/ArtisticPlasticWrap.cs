namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic plastic wrap effect, which simulates a plastic-wrapped appearance with adjustable transparency and smoothness.
/// </summary>
public interface ArtisticPlasticWrap
{
  /// <summary>
  /// Transparency level of the plastic wrap effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Smoothness of the plastic wrap effect, influencing the softness and clarity of the simulated plastic texture.
  /// </summary>
  public Int32? Smoothness { get; set; }
}