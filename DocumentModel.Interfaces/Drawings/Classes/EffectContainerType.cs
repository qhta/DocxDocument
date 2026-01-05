namespace DocumentModel.Drawings;

/// <summary>
///   Defines the EffectContainerType interface.
/// </summary>
public interface EffectContainerType:
{
  /// <summary>
  ///   Effect Container Type
  /// </summary>
  public EffectContainerKind? Type { get; set; }
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
}