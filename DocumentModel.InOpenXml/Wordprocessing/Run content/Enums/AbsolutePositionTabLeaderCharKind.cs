namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the AbsolutePositionTabLeaderCharValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.AbsolutePositionTabLeaderCharValues))]
public enum AbsolutePositionTabLeaderCharKind
{
  /// <summary>
  ///   No Leader Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.None))]
  None,
  /// <summary>
  ///   Dot Leader Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.Dot))]
  Dot,
  /// <summary>
  ///   Hyphen Leader Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.Hyphen))]
  Hyphen,
  /// <summary>
  ///   Underscore Leader Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.Underscore))]
  Underscore,
  /// <summary>
  ///   Centered Dot Leader Character.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.MiddleDot))]
  MiddleDot
}