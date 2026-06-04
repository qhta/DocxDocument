namespace DocumentModel.Math;
/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues))]
public enum VertAlignmentType
{
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Center (Function).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalAlignmentValues.Bottom))]
  Bottom,

}