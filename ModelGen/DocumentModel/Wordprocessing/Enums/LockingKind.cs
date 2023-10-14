namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LockingValues enumeration.
/// </summary>
public enum LockingKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sdtLocked&quot;.
  /// </summary>
  SdtLocked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contentLocked&quot;.
  /// </summary>
  ContentLocked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;unlocked&quot;.
  /// </summary>
  Unlocked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sdtContentLocked&quot;.
  /// </summary>
  SdtContentLocked,
  
}
