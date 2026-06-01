namespace DocumentModel.Drawings;
/// <summary>
///   End ILine Cap
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineCapValues))]
public enum LineCap
{
  /// <summary>
  ///   Round ILine Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Round))]
  Round = 1,

  /// <summary>
  ///   Square ILine Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Square))]
  Square,
  /// <summary>
  ///   Flat ILine Cap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineCapValues.Flat))]
  Flat
}
