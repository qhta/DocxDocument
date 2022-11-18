namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LockingValues enumeration.
/// </summary>
public enum Locking
{
  /// <summary>
  /// SDT Cannot Be Deleted.
  /// </summary>
  [XmlEnum("sdtLocked")]
  SdtLocked,
  
  /// <summary>
  /// Contents Cannot Be Edited At Runtime.
  /// </summary>
  [XmlEnum("contentLocked")]
  ContentLocked,
  
  /// <summary>
  /// No Locking.
  /// </summary>
  [XmlEnum("unlocked")]
  Unlocked,
  
  /// <summary>
  /// Contents Cannot Be Edited At Runtime And SDT Cannot Be Deleted.
  /// </summary>
  [XmlEnum("sdtContentLocked")]
  SdtContentLocked,
  
}
