namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the BreakTextRestartLocationValues enumeration.
/// </summary>
public enum BreakTextRestartLocationKind
{
  /// <summary>
  ///   Restart On Next Line.
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
  ///   Restart On Next Full Line.
  /// </summary>
  All
}