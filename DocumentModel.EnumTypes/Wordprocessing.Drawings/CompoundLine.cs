namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Defines the CompoundLineValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.CompoundLineValues))]
public enum CompoundLine
{
  /// <summary>
  ///   sng.
  /// </summary>
  Simple,
  /// <summary>
  ///   dbl.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Double))]
  Double,
  /// <summary>
  ///   thickThin.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   thinThick.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   triple
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.CompoundLineValues.Triple))]
  Triple
}