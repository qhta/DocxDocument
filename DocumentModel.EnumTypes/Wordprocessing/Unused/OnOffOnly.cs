namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the OnOffOnly enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.OnOffOnlyValues))]
public enum OnOffOnly
{
  /// <summary>
  ///   on.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.OnOffOnlyValues.On))]
  On,
  /// <summary>
  ///   off.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.OnOffOnlyValues.Off))]
  Off
}
