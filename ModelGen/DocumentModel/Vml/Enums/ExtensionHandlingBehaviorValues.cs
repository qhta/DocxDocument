namespace DXV;


/// <summary>
///   VML Extension Handling Behaviors
/// </summary>
public enum ExtensionHandlingBehaviorValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;view&quot;.
  /// </summary>
  [EnumString("view")]
  View,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;edit&quot;.
  /// </summary>
  [EnumString("edit")]
  Edit,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;backwardCompatible&quot;.
  /// </summary>
  [EnumString("backwardCompatible")]
  BackwardCompatible,
  
}
