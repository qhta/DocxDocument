namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
///   Text Wrapping Side
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.WrapSideValues))]
public enum WrapSideKind
{
  /// <summary>
  ///   Both sides.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapSideValues.Both))]
  Both,
  /// <summary>
  ///   Left side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapSideValues.Left))]
  Left,
  /// <summary>
  ///   Right side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapSideValues.Right))]
  Right,
  /// <summary>
  ///   Largest side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.WrapSideValues.Largest))]
  Largest
}