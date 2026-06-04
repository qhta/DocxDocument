namespace DocumentModel.Drawings;
/// <summary>
///   Bevel Presets
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.BevelPresetValues))]
public enum BevelPresets
{
  /// <summary>
  ///   Relaxed Inset.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.RelaxedInset))]
  RelaxedInset,
  /// <summary>
  ///   Circle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Circle))]
  Circle,
  /// <summary>
  ///   Slope.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Slope))]
  Slope,
  /// <summary>
  ///   Cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Cross))]
  Cross,
  /// <summary>
  ///   Angle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Angle))]
  Angle,
  /// <summary>
  ///   Soft Round.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.SoftRound))]
  SoftRound,
  /// <summary>
  ///   Convex.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Convex))]
  Convex,
  /// <summary>
  ///   Cool Slant.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.CoolSlant))]
  CoolSlant,
  /// <summary>
  ///   Divot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Divot))]
  Divot,
  /// <summary>
  ///   Riblet.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.Riblet))]
  Riblet,
  /// <summary>
  ///   Hard Edge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.HardEdge))]
  HardEdge,
  /// <summary>
  ///   Art Deco.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BevelPresetValues.ArtDeco))]
  ArtDeco
}