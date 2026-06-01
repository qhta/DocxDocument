namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Blend Effect.
/// </summary>
public class Blend: ModelElement
{
  /// <summary>
  ///   Blend Mode
  /// </summary>
  public BlendMode? BlendMode { get; set; }

  /// <summary>
  ///   Effect Ito blend.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
}
