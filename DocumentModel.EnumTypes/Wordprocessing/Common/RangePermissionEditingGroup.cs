namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RangePermissionEditingGroupValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues))]
public enum RangePermissionEditingGroup
{
  /// <summary>
  ///   No Users Have Editing Permissions.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.None))]
  None,
  /// <summary>
  ///   All Users Have Editing Permissions.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.Everyone))]
  Everyone,
  /// <summary>
  ///   Administrator Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.Administrators))]
  Administrators,
  /// <summary>
  ///   Contributors Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.Contributors))]
  Contributors,
  /// <summary>
  ///   Editors Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.Editors))]
  Editors,
  /// <summary>
  ///   Owners Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.Owners))]
  Owners,
  /// <summary>
  ///   Current Group.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues.Current))]
  Current
}