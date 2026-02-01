namespace DocumentModel.Drawings;
/// <summary>
///   Line End Width
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineEndWidthValues))]
public enum LineEndWidthKind
{
  /// <summary>
  ///   Small.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndWidthValues.Small))]
  Small,
  /// <summary>
  ///   Medium.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndWidthValues.Medium))]
  Medium,
  /// <summary>
  ///   Large.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndWidthValues.Large))]
  Large
}