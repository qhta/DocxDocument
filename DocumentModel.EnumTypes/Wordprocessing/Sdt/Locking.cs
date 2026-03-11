namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LockingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.LockingValues))]
public enum Locking
{
  /// <summary>
  ///   SDT Cannot Be Deleted.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LockingValues.SdtLocked))]
  SdtLocked,
  /// <summary>
  ///   Contents Cannot Be Edited At Runtime.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LockingValues.ContentLocked))]
  ContentLocked,
  /// <summary>
  ///   No Locking.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LockingValues.Unlocked))]
  Unlocked,
  /// <summary>
  ///   Contents Cannot Be Edited At Runtime And SDT Cannot Be Deleted.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LockingValues.SdtContentLocked))]
  SdtContentLocked
}