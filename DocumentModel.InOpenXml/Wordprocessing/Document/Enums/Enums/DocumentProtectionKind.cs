namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocumentProtectionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DocumentProtectionValues))]
public enum DocumentProtectionKind
{
  /// <summary>
  ///   No Editing Restrictions.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentProtectionValues.None))]
  None,
  /// <summary>
  ///   Allow No Editing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentProtectionValues.ReadOnly))]
  ReadOnly,
  /// <summary>
  ///   Allow Editing of Comments.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentProtectionValues.Comments))]
  Comments,
  /// <summary>
  ///   Allow Editing With Revision Tracking.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentProtectionValues.TrackedChanges))]
  TrackedChanges,
  /// <summary>
  ///   Allow Editing of Form Fields.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocumentProtectionValues.Forms))]
  Forms
}