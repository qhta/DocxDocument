namespace DocumentModel.Drawings;

/// <summary>
/// Represents an alpha modulation effect, which modulates the alpha channel of an image or shape using an effect container.
/// </summary>
public interface AlphaModulationEffect
{
  /// <summary>
  /// Effect container that defines the parameters for alpha modulation.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
}