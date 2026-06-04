namespace DocumentModel.Math;
/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.JustificationValues))]
public enum Justification
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.JustificationValues.Left))]
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.JustificationValues.Right))]
  Right,
  /// <summary>
  ///   Center (Equation).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.JustificationValues.Center))]
  Center,
  /// <summary>
  ///   Centered as Group (Equations).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.JustificationValues.CenterGroup))]
  CenterGroup
}