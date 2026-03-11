namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Text Wrapping Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.WrapValues))]
public enum WrapType
{
  /// <summary>
  ///   Top and bottom wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapValues.TopAndBottom))]
  TopAndBottom,
  /// <summary>
  ///   Square wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapValues.Square))]
  Square,
  /// <summary>
  ///   No wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapValues.None))]
  None,
  /// <summary>
  ///   Tight wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapValues.Tight))]
  Tight,
  /// <summary>
  ///   Through wrapping.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapValues.Through))]
  Through
}