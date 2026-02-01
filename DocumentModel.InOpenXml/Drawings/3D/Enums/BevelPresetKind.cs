namespace DocumentModel.Drawings;
/// <summary>
///   Bevel Presets
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.BevelPresetValues))]
public enum BevelPresetKind
{
  /// <summary>
  ///   Relaxed Inset.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.RelaxedInset))]
  RelaxedInset,
  /// <summary>
  ///   Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Circle))]
  Circle,
  /// <summary>
  ///   Slope.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Slope))]
  Slope,
  /// <summary>
  ///   Cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Cross))]
  Cross,
  /// <summary>
  ///   Angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Angle))]
  Angle,
  /// <summary>
  ///   Soft Round.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.SoftRound))]
  SoftRound,
  /// <summary>
  ///   Convex.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Convex))]
  Convex,
  /// <summary>
  ///   Cool Slant.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.CoolSlant))]
  CoolSlant,
  /// <summary>
  ///   Divot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Divot))]
  Divot,
  /// <summary>
  ///   Riblet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Riblet))]
  Riblet,
  /// <summary>
  ///   Hard Edge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.HardEdge))]
  HardEdge,
  /// <summary>
  ///   Art Deco.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.ArtDeco))]
  ArtDeco
}