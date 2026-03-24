namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of comparison to use when a condition is added to a mail merge process.
/// </summary>
public enum WdMailMergeComparison
{
  /// <summary>
  /// A value is output if the mail merge field is equal to a value.
  /// </summary>
  Equal = unchecked((int)0),
  /// <summary>
  /// A value is output if the mail merge field is not equal to a value.
  /// </summary>
  NotEqual = unchecked((int)1),
  /// <summary>
  /// A value is output if the mail merge field is less than a value.
  /// </summary>
  LessThan = unchecked((int)2),
  /// <summary>
  /// A value is output if the mail merge field is greater than a value. wdMergeIfLessThanOrEqual4 A value is output
  /// if the mail merge field is less than or equal to a value. wdMergeIfGreaterThanOrEqual5 A value is output if
  /// the mail merge field is greater than or equal to a value.
  /// </summary>
  GreaterThan = unchecked((int)3),
  /// <summary>
  /// Specifies the type of comparison to use when a condition is added to a mail merge process.
  /// </summary>
  LessThanOrEqual = unchecked((int)4),
  /// <summary>
  /// Specifies the type of comparison to use when a condition is added to a mail merge process.
  /// </summary>
  GreaterThanOrEqual = unchecked((int)5),
  /// <summary>
  /// A value is output if the mail merge field is blank.
  /// </summary>
  IsBlank = unchecked((int)6),
  /// <summary>
  /// A value is output if the mail merge field is not blank.
  /// </summary>
  IsNotBlank = unchecked((int)7)
}
