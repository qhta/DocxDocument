namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MultiLevelValues enumeration.
/// </summary>
public enum MultiLevelKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;singleLevel&quot;.
  /// </summary>
  [EnumString("singleLevel")]
  SingleLevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;multilevel&quot;.
  /// </summary>
  [EnumString("multilevel")]
  Multilevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hybridMultilevel&quot;.
  /// </summary>
  [EnumString("hybridMultilevel")]
  HybridMultilevel,
  
}
