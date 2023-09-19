namespace DXW;


/// <summary>
///   Defines the DocumentProtectionValues enumeration.
/// </summary>
public enum DocumentProtectionValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;readOnly&quot;.
  /// </summary>
  [EnumString("readOnly")]
  ReadOnly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;comments&quot;.
  /// </summary>
  [EnumString("comments")]
  Comments,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;trackedChanges&quot;.
  /// </summary>
  [EnumString("trackedChanges")]
  TrackedChanges,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;forms&quot;.
  /// </summary>
  [EnumString("forms")]
  Forms,
  
}
