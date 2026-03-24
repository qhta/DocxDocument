namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of major and minor tick marks for an axis.
/// </summary>
public enum XlTickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  Inside = 2,
  /// <summary>
  /// No mark
  /// </summary>
  Outside = 3,
  /// <summary>
  /// Crosses the axis
  /// </summary>
  Cross = 4,
  /// <summary>
  /// Specifies the position of major and minor tick marks for an axis.
  /// </summary>
  None = -4142
}
