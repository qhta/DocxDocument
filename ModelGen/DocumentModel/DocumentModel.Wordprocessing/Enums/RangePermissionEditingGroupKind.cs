namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RangePermissionEditingGroupValues enumeration.
/// </summary>
public enum RangePermissionEditingGroupKind
{
  /// <summary>
  /// No Users Have Editing Permissions.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// All Users Have Editing Permissions.
  /// </summary>
  [XmlEnum("everyone")]
  Everyone,
  
  /// <summary>
  /// Administrator Group.
  /// </summary>
  [XmlEnum("administrators")]
  Administrators,
  
  /// <summary>
  /// Contributors Group.
  /// </summary>
  [XmlEnum("contributors")]
  Contributors,
  
  /// <summary>
  /// Editors Group.
  /// </summary>
  [XmlEnum("editors")]
  Editors,
  
  /// <summary>
  /// Owners Group.
  /// </summary>
  [XmlEnum("owners")]
  Owners,
  
  /// <summary>
  /// Current Group.
  /// </summary>
  [XmlEnum("current")]
  Current,
  
}
