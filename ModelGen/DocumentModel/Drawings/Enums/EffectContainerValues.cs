namespace DocumentFormat.OpenXml.Drawings;


/// <summary>
///   Effect Container Type
/// </summary>
public enum EffectContainerValues
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
