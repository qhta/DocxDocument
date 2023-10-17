namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MultiLevelValues enumeration.
/// </summary>
public enum MultiLevelKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;singleLevel&quot;.
  /// </summary>
  SingleLevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;multilevel&quot;.
  /// </summary>
  Multilevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hybridMultilevel&quot;.
  /// </summary>
  HybridMultilevel,
  
}
