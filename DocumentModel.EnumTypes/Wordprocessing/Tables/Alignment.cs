namespace DocumentModel.Vml;
/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues))]
public enum Alignment
{
  /// <summary>
  ///   Top Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Middle Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues.Middle))]
  Middle,
  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Left Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.AlignmentValues.Right))]
  Right
}