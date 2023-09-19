namespace DocumentModel.Drawings;


/// <summary>
///   This simple type determines the relationship between effects in a container, either sibling or tree.
/// </summary>
public partial class EffectContainerType
{
  
  /// <summary>
  ///   Effect Container Type
  /// </summary>
  [SchemaAttr("type")]
  public DocumentModel.Drawings.EffectContainerValues? Type { get; set; }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [SchemaAttr("name")]
  public String? Name { get; set; }
  
}
