namespace DocumentModel.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public partial interface EffectContainerType
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public DocumentModel.Drawings.EffectContainerKind? Type { get; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
}
