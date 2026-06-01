namespace DocumentModel.Drawings;
/// <summary>
///   Compound ILine Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.CompoundLineValues))]
public enum CompoundLine
{
  /// <summary>
  ///   Single ILine.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Single))]
  Single,
  /// <summary>
  ///   Double ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Double))]
  Double,
  /// <summary>
  ///   Thick Thin Double ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thin Thick Double ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thin Thick Thin Triple ILines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Triple))]
  Triple
}
