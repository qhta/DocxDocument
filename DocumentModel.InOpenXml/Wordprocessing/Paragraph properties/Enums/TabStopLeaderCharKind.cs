namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TabStopLeaderCharValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TabStopLeaderCharValues))]
public enum TabStopLeaderCharKind
{
  /// <summary>
  ///   No tab stop leader.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopLeaderCharValues.None))]
  None,
  /// <summary>
  ///   Dotted leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopLeaderCharValues.Dot))]
  Dot,
  /// <summary>
  ///   Dashed tab stop leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopLeaderCharValues.Hyphen))]
  Hyphen,
  /// <summary>
  ///   Solid leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopLeaderCharValues.Underscore))]
  Underscore,
  /// <summary>
  ///   Heavy solid leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopLeaderCharValues.Heavy))]
  Heavy,
  /// <summary>
  ///   Middle dot leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopLeaderCharValues.MiddleDot))]
  MiddleDot
}