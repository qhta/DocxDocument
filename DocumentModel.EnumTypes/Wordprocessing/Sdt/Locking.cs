namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LockingValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.LockingValues))]
public enum Locking
{
  /// <summary>
  ///   SDT Cannot Be Deleted.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LockingValues.SdtLocked))]
  SdtLocked,
  /// <summary>
  ///   Contents Cannot Be Edited At Runtime.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LockingValues.ContentLocked))]
  ContentLocked,
  /// <summary>
  ///   No Locking.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LockingValues.Unlocked))]
  Unlocked,
  /// <summary>
  ///   Contents Cannot Be Edited At Runtime And SDT Cannot Be Deleted.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LockingValues.SdtContentLocked))]
  SdtContentLocked
}