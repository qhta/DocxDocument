namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of comparison to use when a condition is added to a mail merge process.
/// </summary>
public enum WdMailMergeComparison
{
  /// <summary>
  /// A value is output if the mail merge field is equal to a value.
  /// </summary>
  wdMergeIfEqual = unchecked((int)0),
  /// <summary>
  /// A value is output if the mail merge field is not equal to a value.
  /// </summary>
  wdMergeIfNotEqual = unchecked((int)1),
  /// <summary>
  /// A value is output if the mail merge field is less than a value.
  /// </summary>
  wdMergeIfLessThan = unchecked((int)2),
  /// <summary>
  /// A value is output if the mail merge field is greater than a value. wdMergeIfLessThanOrEqual4 A value is output
  /// if the mail merge field is less than or equal to a value. wdMergeIfGreaterThanOrEqual5 A value is output if
  /// the mail merge field is greater than or equal to a value.
  /// </summary>
  wdMergeIfGreaterThan = unchecked((int)3),
  /// <summary>
  /// Specifies the type of comparison to use when a condition is added to a mail merge process.
  /// </summary>
  wdMergeIfLessThanOrEqual = unchecked((int)4),
  /// <summary>
  /// Specifies the type of comparison to use when a condition is added to a mail merge process.
  /// </summary>
  wdMergeIfGreaterThanOrEqual = unchecked((int)5),
  /// <summary>
  /// A value is output if the mail merge field is blank.
  /// </summary>
  wdMergeIfIsBlank = unchecked((int)6),
  /// <summary>
  /// A value is output if the mail merge field is not blank.
  /// </summary>
  wdMergeIfIsNotBlank = unchecked((int)7)
}
