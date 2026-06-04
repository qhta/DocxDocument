namespace DocumentModel.Drawings;
/// <summary>
///   End ILine Cap
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.LineCapValues))]
public enum LineCap
{
  /// <summary>
  ///   Round ILine Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineCapValues.Round))]
  Round = 1,

  /// <summary>
  ///   Square ILine Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineCapValues.Square))]
  Square,
  /// <summary>
  ///   Flat ILine Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.LineCapValues.Flat))]
  Flat
}
