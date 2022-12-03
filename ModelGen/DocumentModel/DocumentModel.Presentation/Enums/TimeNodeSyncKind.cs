namespace DocumentModel.Presentation;

/// <summary>
/// Time Node Sync Type
/// </summary>
public enum TimeNodeSyncKind
{
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// TimeNode Sync Enum ( Can Slip ).
  /// </summary>
  [XmlEnum("canSlip")]
  CanSlip,
  
  /// <summary>
  /// TimeNode Sync Enum ( Locked ).
  /// </summary>
  [XmlEnum("locked")]
  Locked,
  
}
