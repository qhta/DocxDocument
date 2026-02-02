namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the OnOffOnlyValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.OnOffOnlyValues))]
public enum OnOffOnlyKind
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