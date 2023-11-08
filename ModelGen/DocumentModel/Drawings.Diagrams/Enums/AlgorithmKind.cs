namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Algorithm Types
/// </summary>
public enum AlgorithmKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;composite&quot;.
  /// </summary>
  Composite,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;conn&quot;.
  /// </summary>
  Connector,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cycle&quot;.
  /// </summary>
  Cycle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hierChild&quot;.
  /// </summary>
  HierarchyChild,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hierRoot&quot;.
  /// </summary>
  HierarchyRoot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyra&quot;.
  /// </summary>
  Pyramid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lin&quot;.
  /// </summary>
  Linear,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sp&quot;.
  /// </summary>
  Space,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tx&quot;.
  /// </summary>
  Text,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snake&quot;.
  /// </summary>
  Snake,
  
}
