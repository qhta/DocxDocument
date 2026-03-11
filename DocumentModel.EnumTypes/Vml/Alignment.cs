namespace DocumentModel.Vml;
/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.AlignmentValues))]
public enum Alignment
{
  /// <summary>
  ///   Top Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Middle Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AlignmentValues.Middle))]
  Middle,
  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Left Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.AlignmentValues.Right))]
  Right
}