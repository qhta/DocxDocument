namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the EmphasisMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.EmphasisMarkValues))]
public enum EmphasisMark
{
  /// <summary>
  ///   No Emphasis Mark.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EmphasisMarkValues.None))]
  None,
  /// <summary>
  ///   Dot Emphasis Mark Above Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EmphasisMarkValues.Dot))]
  Dot,
  /// <summary>
  ///   Comma Emphasis Mark Above Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EmphasisMarkValues.Comma))]
  Comma,
  /// <summary>
  ///   Circle Emphasis Mark Above Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EmphasisMarkValues.Circle))]
  Circle,
  /// <summary>
  ///   Dot Emphasis Mark Below Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EmphasisMarkValues.UnderDot))]
  UnderDot
}