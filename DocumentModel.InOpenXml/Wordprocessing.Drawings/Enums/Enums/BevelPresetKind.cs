namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Defines the BevelPresetTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.BevelPresetValues))]
public enum BevelPresetKind
{
  /// <summary>
  ///   relaxedInset.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.RelaxedInset))]
  RelaxedInset,
  /// <summary>
  ///   circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Circle))]
  Circle,
  /// <summary>
  ///   slope.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Slope))]
  Slope,
  /// <summary>
  ///   cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Cross))]
  Cross,
  /// <summary>
  ///   angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Angle))]
  Angle,
  /// <summary>
  ///   softRound.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.SoftRound))]
  SoftRound,
  /// <summary>
  ///   convex.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Convex))]
  Convex,
  /// <summary>
  ///   coolSlant.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.CoolSlant))]
  CoolSlant,
  /// <summary>
  ///   divot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Divot))]
  Divot,
  /// <summary>
  ///   riblet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.Riblet))]
  Riblet,
  /// <summary>
  ///   hardEdge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.HardEdge))]
  HardEdge,
  /// <summary>
  ///   artDeco.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BevelPresetValues.ArtDeco))]
  ArtDeco
}