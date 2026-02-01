namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RangePermissionEditingGroupValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.RangePermissionEditingGroupValues))]
public enum RangePermissionEditingGroupKind
{
  /// <summary>
  ///   No Users Have Editing Permissions.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.None))]
  None,
  /// <summary>
  ///   All Users Have Editing Permissions.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.Everyone))]
  Everyone,
  /// <summary>
  ///   Administrator Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.Administrators))]
  Administrators,
  /// <summary>
  ///   Contributors Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.Contributors))]
  Contributors,
  /// <summary>
  ///   Editors Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.Editors))]
  Editors,
  /// <summary>
  ///   Owners Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.Owners))]
  Owners,
  /// <summary>
  ///   Current Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RangePermissionEditingGroupValues.Current))]
  Current
}