namespace DocumentModel.Drawings;
/// <summary>
///   Text Anchoring Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextAnchoringTypeValues))]
public enum TextAnchoring
{
  /// <summary>
  ///   Text Anchoring Type Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAnchoringTypeValues.Top))]
  Top,
  /// <summary>
  ///   Text Anchor Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAnchoringTypeValues.Center))]
  Center,
  /// <summary>
  ///   Text Anchor Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextAnchoringTypeValues.Bottom))]
  Bottom
}