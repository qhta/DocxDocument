namespace DocumentModel.Drawings;
/// <summary>
///   End Line Cap
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineCapValues))]
public enum LineCap
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Round Line Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Round))]
  Round = 1,

  /// <summary>
  ///   Square Line Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Square))]
  Square,
  /// <summary>
  ///   Flat Line Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Flat))]
  Flat
}