namespace DocumentModel.Drawings;
/// <summary>
///   Path Fill Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PathFillModeValues))]
public enum PathFillMode
{
  /// <summary>
  ///   No Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathFillModeValues.None))]
  None,
  /// <summary>
  ///   Normal Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathFillModeValues.Norm))]
  Norm,
  /// <summary>
  ///   Lighten Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathFillModeValues.Lighten))]
  Lighten,
  /// <summary>
  ///   Lighten Path Fill Less.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathFillModeValues.LightenLess))]
  LightenLess,
  /// <summary>
  ///   Darken Path Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathFillModeValues.Darken))]
  Darken,
  /// <summary>
  ///   Darken Path Fill Less.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PathFillModeValues.DarkenLess))]
  DarkenLess
}