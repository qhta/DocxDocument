namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the NumberFormValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10W.NumberFormValues))]
public enum NumberFormKind
{
  /// <summary>
  ///   default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.NumberFormValues.Default))]
  Default,
  /// <summary>
  ///   lining.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.NumberFormValues.Lining))]
  Lining,
  /// <summary>
  ///   oldStyle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.NumberFormValues.OldStyle))]
  OldStyle
}