namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocumentProtectionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocumentProtectionKind
{
  /// <summary>
  ///   No Editing Restrictions.
  /// </summary>
  None,

  /// <summary>
  ///   Allow No Editing.
  /// </summary>
  ReadOnly,

  /// <summary>
  ///   Allow Editing of Comments.
  /// </summary>
  Comments,

  /// <summary>
  ///   Allow Editing With Revision Tracking.
  /// </summary>
  TrackedChanges,

  /// <summary>
  ///   Allow Editing of Form Fields.
  /// </summary>
  Forms
}