namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of major and minor tick marks for an axis.
/// </summary>
public enum XlTickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  xlTickMarkInside = unchecked((int)2),
  /// <summary>
  /// No mark
  /// </summary>
  xlTickMarkOutside = unchecked((int)3),
  /// <summary>
  /// Crosses the axis
  /// </summary>
  xlTickMarkCross = unchecked((int)4),
  /// <summary>
  /// Specifies the position of major and minor tick marks for an axis.
  /// </summary>
  xlTickMarkNone = unchecked((int)-4142)
}
