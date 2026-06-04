namespace DocumentModel.Drawings;
/// <summary>
///   ILine End Width
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.LineEndWidthValues))]
public enum LineEndWidth
{
  /// <summary>
  ///   Small.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndWidthValues.Small))]
  Small,
  /// <summary>
  ///   Medium.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndWidthValues.Medium))]
  Medium,
  /// <summary>
  ///   Large.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineEndWidthValues.Large))]
  Large
}
