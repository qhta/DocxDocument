namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
/// Defines the WrapSide enumeration.
/// Used in types such as TextWrap, WrapSide.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.WrapSideValues))]
public enum WrapSide
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
