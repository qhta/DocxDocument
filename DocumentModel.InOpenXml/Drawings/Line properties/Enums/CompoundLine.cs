namespace DocumentModel.Drawings;
/// <summary>
///   Compound Line Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.CompoundLineValues))]
public enum CompoundLine
{
  /// <summary>
  ///   Single Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Single))]
  Single,
  /// <summary>
  ///   Double Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Double))]
  Double,
  /// <summary>
  ///   Thick Thin Double Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thin Thick Double Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thin Thick Thin Triple Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Triple))]
  Triple
}