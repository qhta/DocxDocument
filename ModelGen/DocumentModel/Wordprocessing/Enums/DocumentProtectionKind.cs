namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocumentProtectionValues enumeration.
/// </summary>
public enum DocumentProtectionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;readOnly&quot;.
  /// </summary>
  ReadOnly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;comments&quot;.
  /// </summary>
  Comments,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;trackedChanges&quot;.
  /// </summary>
  TrackedChanges,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;forms&quot;.
  /// </summary>
  Forms,
  
}
