namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the RangePermissionEditingGroupValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RangePermissionEditingGroupKind
{
  /// <summary>
  ///   No Users Have Editing Permissions.
  /// </summary>
  None,

  /// <summary>
  ///   All Users Have Editing Permissions.
  /// </summary>
  Everyone,

  /// <summary>
  ///   Administrator Group.
  /// </summary>
  Administrators,

  /// <summary>
  ///   Contributors Group.
  /// </summary>
  Contributors,

  /// <summary>
  ///   Editors Group.
  /// </summary>
  Editors,

  /// <summary>
  ///   Owners Group.
  /// </summary>
  Owners,

  /// <summary>
  ///   Current Group.
  /// </summary>
  Current
}