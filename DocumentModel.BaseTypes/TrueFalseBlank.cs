namespace DocumentModel;

/// <summary>
/// Enumeration representing True, False, or Blank values.
/// </summary>
public enum TrueFalseBlank
{
  /// <summary>
  /// Indicates a negative or disabled state.
  /// </summary>
  False = 0,

  /// <summary>
  /// Indicates an affirmative or enabled state.
  /// </summary>
  True = 1,

  /// <summary>
  /// Indicates an indeterminate or blank state.
  /// </summary>
  Blank = 2
}