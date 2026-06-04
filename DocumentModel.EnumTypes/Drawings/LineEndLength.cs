namespace DocumentModel.Drawings;
/// <summary>
///   ILine End Length
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.LineEndLengthValues))]
public enum LineEndLength
{
  /// <summary>
  ///   Small.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndLengthValues.Small))]
  Small,
  /// <summary>
  ///   Medium.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndLengthValues.Medium))]
  Medium,
  /// <summary>
  ///   Large.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndLengthValues.Large))]
  Large
}
