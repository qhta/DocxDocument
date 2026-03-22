namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spacing for an equation.
/// </summary>
public enum WdOMathSpacingRule
{
  /// <summary>
  /// Single spacing.
  /// </summary>
  wdOMathSpacingSingle = unchecked((int)0),
  /// <summary>
  /// One and half spaces for each line.
  /// </summary>
  wdOMathSpacing1pt5 = unchecked((int)1),
  /// <summary>
  /// Double spacing.
  /// </summary>
  wdOMathSpacingDouble = unchecked((int)2),
  /// <summary>
  /// Exact spacing measurement.
  /// </summary>
  wdOMathSpacingExactly = unchecked((int)3),
  /// <summary>
  /// Custom spacing measurement.
  /// </summary>
  wdOMathSpacingMultiple = unchecked((int)4)
}
