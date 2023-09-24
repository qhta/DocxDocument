namespace DocumentModel.Drawings;


/// <summary>
///   This simple type determines the relationship between effects in a container, either sibling or tree.
/// </summary>
public partial class EffectContainerType
{
  
  /// <summary>
  ///   Effect Container Type
  /// </summary>
  public EffectContainerKind? Type { get; set; }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }
  
}
