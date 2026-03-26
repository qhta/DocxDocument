namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the line cap style options for drawing lines in WordprocessingML documents.
/// This enumeration provides values for different line cap shapes, supporting advanced graphical rendering and customization of line endings in document drawings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineCapValues))]
public enum LineCap
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  /// Round line cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Round))]
  Round = 1,

  /// <summary>
  /// Square line cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Square))]
  Square,
  /// <summary>
  /// Flat line cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Flat))]
  Flat
}