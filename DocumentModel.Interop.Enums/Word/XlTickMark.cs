namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of major and minor tick marks for an axis.
/// </summary>
public enum XlTickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  Inside = unchecked((int)2),
  /// <summary>
  /// No mark
  /// </summary>
  Outside = unchecked((int)3),
  /// <summary>
  /// Crosses the axis
  /// </summary>
  Cross = unchecked((int)4),
  /// <summary>
  /// Specifies the position of major and minor tick marks for an axis.
  /// </summary>
  None = unchecked((int)-4142)
}
