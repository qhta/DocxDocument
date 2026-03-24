namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spacing for an equation.
/// </summary>
public enum WdOMathSpacingRule
{
  /// <summary>
  /// Single spacing.
  /// </summary>
  Single = unchecked((int)0),
  /// <summary>
  /// One and half spaces for each line.
  /// </summary>
  OnePtFive = unchecked((int)1),
  /// <summary>
  /// Double spacing.
  /// </summary>
  Double = unchecked((int)2),
  /// <summary>
  /// Exact spacing measurement.
  /// </summary>
  Exactly = unchecked((int)3),
  /// <summary>
  /// Custom spacing measurement.
  /// </summary>
  Multiple = unchecked((int)4)
}
