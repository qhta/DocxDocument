namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the BreakTextRestartLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues))]
public enum BreakTextRestartLocation
{
  /// <summary>
  ///   Restart On Next Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues.None))]
  None,
  /// <summary>
  ///   Restart In Next Text Region When In Leftmost Position.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues.Left))]
  Left,
  /// <summary>
  ///   Restart In Next Text Region When In Rightmost Position.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues.Right))]
  Right,
  /// <summary>
  ///   Restart On Next Full Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BreakTextRestartLocationValues.All))]
  All
}