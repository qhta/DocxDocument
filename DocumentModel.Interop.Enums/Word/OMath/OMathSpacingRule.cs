namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies spacing for an equation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathspacingrule?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathSpacingRule))]
public enum OMathSpacingRule
{
  /// <summary>
  /// Single spacing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingSingle))]
  Single = 0,
  /// <summary>
  /// 1.5 spacing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacing1pt5))]
  OnePtFive = 1,
  /// <summary>
  /// Double spacing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingDouble))]
  Double = 2,
  /// <summary>
  /// Exact spacing measurement.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingExactly))]
  Exactly = 3,
  /// <summary>
  /// Custom spacing measurement.
  /// </summary>  
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingMultiple))]
  Multiple = 4
}
