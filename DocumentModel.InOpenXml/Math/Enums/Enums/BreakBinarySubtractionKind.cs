namespace DocumentModel.Math;
/// <summary>
///   Defines the BreakBinarySubtractionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.BreakBinarySubtractionValues))]
public enum BreakBinarySubtractionKind
{
  /// <summary>
  ///   Minus is left on the end of the line and repeated on the beginning of the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BreakBinarySubtractionValues.MinusMinus))]
  MinusMinus,
  /// <summary>
  ///   Minus is left on the end of the line and plus is placed on the beginning of the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BreakBinarySubtractionValues.MinusPlus))]
  MinusPlus,
  /// <summary>
  ///   Plus is left on the end of the line and minus is placed on the beginning of the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.BreakBinarySubtractionValues.PlusMinus))]
  PlusMinus
}