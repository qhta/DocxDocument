namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spacing for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathspacingrule?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathSpacingRule
{
  /// <summary>
  /// Single spacing.
  /// </summary>
  Single = 0,
  /// <summary>
  /// Specifies spacing for an equation.
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
