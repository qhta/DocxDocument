namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the BreakTextRestartLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.BreakTextRestartLocationValues))]
public enum BreakTextRestartLocation
{
  /// <summary>
  ///   Restart On Next Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakTextRestartLocationValues.None))]
  None,
  /// <summary>
  ///   Restart In Next Text Region When In Leftmost Position.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakTextRestartLocationValues.Left))]
  Left,
  /// <summary>
  ///   Restart In Next Text Region When In Rightmost Position.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakTextRestartLocationValues.Right))]
  Right,
  /// <summary>
  ///   Restart On Next Full Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakTextRestartLocationValues.All))]
  All
}