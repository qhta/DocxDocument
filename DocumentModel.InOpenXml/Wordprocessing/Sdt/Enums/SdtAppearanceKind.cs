namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the SdtAppearance enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO13W.SdtAppearance))]
public enum SdtAppearanceKind
{
  /// <summary>
  ///   boundingBox.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO13W.SdtAppearance.BoundingBox))]
  BoundingBox,
  /// <summary>
  ///   tags.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO13W.SdtAppearance.Tags))]
  Tags,
  /// <summary>
  ///   hidden.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO13W.SdtAppearance.Hidden))]
  Hidden
}