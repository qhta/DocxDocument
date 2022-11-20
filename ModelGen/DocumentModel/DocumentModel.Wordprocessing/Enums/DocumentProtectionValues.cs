namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocumentProtectionValues enumeration.
/// </summary>
public enum DocumentProtectionValues
{
  /// <summary>
  /// No Editing Restrictions.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Allow No Editing.
  /// </summary>
  [XmlEnum("readOnly")]
  ReadOnly,
  
  /// <summary>
  /// Allow Editing of Comments.
  /// </summary>
  [XmlEnum("comments")]
  Comments,
  
  /// <summary>
  /// Allow Editing With Revision Tracking.
  /// </summary>
  [XmlEnum("trackedChanges")]
  TrackedChanges,
  
  /// <summary>
  /// Allow Editing of Form Fields.
  /// </summary>
  [XmlEnum("forms")]
  Forms,
  
}
