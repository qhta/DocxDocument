namespace DocumentModel.Vml;


/// <summary>
///   VML Extension Handling Behaviors
/// </summary>
public enum ExtensionHandlingBehaviorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;view&quot;.
  /// </summary>
  View,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;edit&quot;.
  /// </summary>
  Edit,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;backwardCompatible&quot;.
  /// </summary>
  BackwardCompatible,
  
}
