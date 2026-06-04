namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocumentProtectionValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues))]
public enum DocumentProtectionType
{
  /// <summary>
  ///   No Editing Restrictions.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues.None))]
  None,
  /// <summary>
  ///   Allow No Editing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues.ReadOnly))]
  ReadOnly,
  /// <summary>
  ///   Allow Editing of Comments.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues.Comments))]
  Comments,
  /// <summary>
  ///   Allow Editing With Revision Tracking.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues.TrackedChanges))]
  TrackedChanges,
  /// <summary>
  ///   Allow Editing of Form Fields.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues.Forms))]
  Forms
}