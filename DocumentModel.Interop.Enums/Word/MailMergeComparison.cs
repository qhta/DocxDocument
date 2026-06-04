namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of comparison to use when a condition is added to a mail merge process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergecomparison?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailMergeComparison")]
public enum MailMergeComparison
{
  /// <summary>
  /// A value is output if the mail merge field is equal to a value.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfEqual")]
  Equal = 0,
  /// <summary>
  /// A value is output if the mail merge field is not equal to a value.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfNotEqual")]
  NotEqual = 1,
  /// <summary>
  /// A value is output if the mail merge field is less than a value.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfLessThan")]
  LessThan = 2,
  /// <summary>
  /// A value is output if the mail merge field is greater than a value.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfGreaterThan")]
  GreaterThan = 3,
  /// <summary>
  /// A value is output if the mail merge field is less than or equal to a value.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfLessThanOrEqual")]
  LessThanOrEqual = 4,
  /// <summary>
  /// A value is output if the mail merge field is greater than or equal to a value.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfGreaterThanOrEqual")]
  GreaterThanOrEqual = 5,
  /// <summary>
  /// A value is output if the mail merge field is blank.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfIsBlank")]
  IsBlank = 6,
  /// <summary>
  /// A value is output if the mail merge field is not blank.
  /// </summary>
  [WordInteropEnumValue("wdMergeIfIsNotBlank")]
  IsNotBlank = 7
}
