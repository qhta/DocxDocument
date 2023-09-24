namespace DocumentModel.Drawings;


/// <summary>
///   Effect Container Type
/// </summary>
public enum EffectContainerKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sib&quot;.
  /// </summary>
  [EnumString("sib")]
  Sibling,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tree&quot;.
  /// </summary>
  [EnumString("tree")]
  Tree,
  
}
