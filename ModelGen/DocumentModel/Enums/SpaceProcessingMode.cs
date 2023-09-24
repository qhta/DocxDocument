namespace DocumentModel;


/// <summary>
///   Defines the SpaceProcessingModeValues enumeration.
/// </summary>
public enum SpaceProcessingMode
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;preserve&quot;.
  /// </summary>
  [EnumString("preserve")]
  Preserve,
  
}
