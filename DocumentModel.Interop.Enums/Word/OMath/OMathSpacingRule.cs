namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies spacing for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathspacingrule?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOMathSpacingRule")]
public enum OMathSpacingRule
{
  /// <summary>
  /// Single spacing.
  /// </summary>
  [WordInteropEnumValue("wdOMathSpacingSingle")]
  Single = 0,
  /// <summary>
  /// 1.5 spacing.
  /// </summary>
  [WordInteropEnumValue("wdOMathSpacing1pt5")]
  OnePtFive = 1,
  /// <summary>
  /// Double spacing.
  /// </summary>
  [WordInteropEnumValue("wdOMathSpacingDouble")]
  Double = 2,
  /// <summary>
  /// Exact spacing measurement.
  /// </summary>
  [WordInteropEnumValue("wdOMathSpacingExactly")]
  Exactly = 3,
  /// <summary>
  /// Custom spacing measurement.
  /// </summary>  
  [WordInteropEnumValue("wdOMathSpacingMultiple")]
  Multiple = 4
}
