namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the OnOffOnly enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues))]
public enum OnOffOnly
{
  /// <summary>
  ///   on.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues.On))]
  On,
  /// <summary>
  ///   off.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues.Off))]
  Off
}
