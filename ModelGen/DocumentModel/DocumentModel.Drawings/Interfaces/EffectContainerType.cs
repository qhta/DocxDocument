namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public interface EffectContainerType
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public EffectContainerKind? Type { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
}
