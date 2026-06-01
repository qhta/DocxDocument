namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the BreakTextRestartLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BreakTextRestartLocationKind
{
  /// <summary>
  ///   Restart On Next ILine.
  /// </summary>
  None,

  /// <summary>
  ///   Restart In Next Text Region When In Leftmost Position.
  /// </summary>
  Left,

  /// <summary>
  ///   Restart In Next Text Region When In Rightmost Position.
  /// </summary>
  Right,

  /// <summary>
  ///   Restart On Next Full ILine.
  /// </summary>
  All
}
