namespace DocumentModel.Vml;
/// <summary>
///   Stroke End Cap Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeEndCapValues))]
public enum StrokeEndCap
{
  /// <summary>
  ///   Flat End.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeEndCapValues.Flat))]
  Flat,
  /// <summary>
  ///   Square End.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeEndCapValues.Square))]
  Square,
  /// <summary>
  ///   Round End.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeEndCapValues.Round))]
  Round
}