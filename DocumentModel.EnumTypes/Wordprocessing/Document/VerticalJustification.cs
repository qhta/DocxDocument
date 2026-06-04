namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.VerticalJustificationValues))]
public enum VerticalJustification
{
  /// <summary>
  ///   Align Top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalJustificationValues.Top))]
  Top,
  /// <summary>
  ///   Align Center.
  /// </summary>
  Center,
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  Both,
  /// <summary>
  ///   Align Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.VerticalJustificationValues.Bottom))]
  Bottom
}