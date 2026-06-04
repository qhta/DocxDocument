namespace DocumentModel.Wordprocessing;

/// <summary>
///  Defines the AbsolutePositionTabLeaderChar enumeration.
/// </summary>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues))]
public enum AbsolutePositionTabLeaderChar
{
  /// <summary>
  /// Specifies that no leader character is used for the absolute position tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues.None))]
  None,
  /// <summary>
  /// Specifies that the tab leader character is a dot ('.').
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues.Dot))]
  Dot,
  /// <summary>
  /// Specifies that a hyphen character is used as the leader for the absolute position tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues.Hyphen))]
  Hyphen,
  /// <summary>
  /// Specifies that the tab leader character is an underscore.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues.Underscore))]
  Underscore,
  /// <summary>
  /// Specifies that the tab leader character is a middle dot (·).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues.MiddleDot))]
  MiddleDot,
}