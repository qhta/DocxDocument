namespace DocumentModel.Drawings;
/// <summary>
///   ILine End Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineEndValues))]
public enum LineEndType
{
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndValues.None))]
  None,
  /// <summary>
  ///   Triangle Arrow Head.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndValues.Triangle))]
  Triangle,
  /// <summary>
  ///   Stealth Arrow.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndValues.Stealth))]
  Stealth,
  /// <summary>
  ///   Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndValues.Diamond))]
  Diamond,
  /// <summary>
  ///   Oval.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndValues.Oval))]
  Oval,
  /// <summary>
  ///   Arrow Head.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndValues.Arrow))]
  Arrow
}
