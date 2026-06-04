namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TabStopLeaderCharValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues))]
public enum TabStopLeader
{
  /// <summary>
  ///   No tab stop leader.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues.None))]
  None,
  /// <summary>
  ///   Dotted leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues.Dot))]
  Dot,
  /// <summary>
  ///   Dashed tab stop leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues.Hyphen))]
  Hyphen,
  /// <summary>
  ///   Solid leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues.Underscore))]
  Underscore,
  /// <summary>
  ///   Heavy solid leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues.Heavy))]
  Heavy,
  /// <summary>
  ///   Middle dot leader line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues.MiddleDot))]
  MiddleDot
}