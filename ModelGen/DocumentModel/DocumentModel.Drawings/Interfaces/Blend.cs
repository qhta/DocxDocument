namespace DocumentModel.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public interface Blend
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public BlendMode? BlendMode { get ; set; }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public EffectContainer? EffectContainer { get ; set; }
  
}
