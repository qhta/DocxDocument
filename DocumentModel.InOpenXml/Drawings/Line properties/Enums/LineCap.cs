namespace DocumentModel.Drawings;
/// <summary>
///   End Line Cap
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineCapValues))]
public enum LineCap
{
  /// <summary>
  ///   Round Line Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Round))]
  Round,
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