namespace DocumentModel.Wordprocessing;

/// <summary>
///  Defines the AbsolutePositionTabLeaderChar enumeration.
/// </summary>
[OpenXmlEnumType(typeof(DXW.AbsolutePositionTabLeaderCharValues))]
public enum AbsolutePositionTabLeaderChar
{
  /// <summary>
  /// Specifies that no leader character is used for the absolute position tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.None))]
  None,
  /// <summary>
  /// Specifies that the tab leader character is a dot ('.').
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.Dot))]
  Dot,
  /// <summary>
  /// Specifies that a hyphen character is used as the leader for the absolute position tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.Hyphen))]
  Hyphen,
  /// <summary>
  /// Specifies that the tab leader character is an underscore.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.Underscore))]
  Underscore,
  /// <summary>
  /// Specifies that the tab leader character is a middle dot (·).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabLeaderCharValues.MiddleDot))]
  MiddleDot,
}