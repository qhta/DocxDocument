namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spacing for an equation.
/// </summary>
public enum WdOMathSpacingRule
{
  /// <summary>
  /// Single spacing.
  /// </summary>
  Single = 0,
  /// <summary>
  /// One and half spaces for each line.
  /// </summary>
  OnePtFive = 1,
  /// <summary>
  /// Double spacing.
  /// </summary>
  Double = 2,
  /// <summary>
  /// Exact spacing measurement.
  /// </summary>
  Exactly = 3,
  /// <summary>
  /// Custom spacing measurement.
  /// </summary>
  Multiple = 4
}
