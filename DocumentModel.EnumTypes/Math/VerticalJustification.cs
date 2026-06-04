namespace DocumentModel.Math;
/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.VerticalJustificationValues))]
public enum VerticalJustification
{
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalJustificationValues.Top))]
  Top,
  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalJustificationValues.Bottom))]
  Bottom
}