namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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