namespace DocumentModel.Drawings;

/// <summary>
/// Represents a blend effect, allowing the combination of effects using a specified blend mode.
/// </summary>
public class Blend: ModelElement
{
  /// <summary>
  /// Blend mode used to combine effects.
  /// </summary>
  public BlendMode? BlendMode { get; set; }

  /// <summary>
  /// Effect container that is blended using the specified blend mode.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
}