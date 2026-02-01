namespace DocumentModel.Drawings;
/// <summary>
///   Line End Length
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.LineEndLengthValues))]
public enum LineEndLengthKind
{
  /// <summary>
  ///   Small.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndLengthValues.Small))]
  Small,
  /// <summary>
  ///   Medium.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndLengthValues.Medium))]
  Medium,
  /// <summary>
  ///   Large.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.LineEndLengthValues.Large))]
  Large
}