namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of comparison to use when a condition is added to a mail merge process.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailmergecomparison?view=office-pia` for Office interop details.
/// </remarks>
public enum MailMergeComparison
{
  /// <summary>
  /// A value is output if the mail merge field is equal to a value.
  /// </summary>
  Equal = 0,
  /// <summary>
  /// A value is output if the mail merge field is not equal to a value.
  /// </summary>
  NotEqual = 1,
  /// <summary>
  /// A value is output if the mail merge field is less than a value.
  /// </summary>
  LessThan = 2,
  /// <summary>
  /// A value is output if the mail merge field is greater than a value.
  /// </summary>
  GreaterThan = 3,
  /// <summary>
  /// A value is output if the mail merge field is less than or equal to a value.
  /// </summary>
  LessThanOrEqual = 4,
  /// <summary>
  /// A value is output if the mail merge field is greater than or equal to a value.
  /// </summary>
  GreaterThanOrEqual = 5,
  /// <summary>
  /// A value is output if the mail merge field is blank.
  /// </summary>
  IsBlank = 6,
  /// <summary>
  /// A value is output if the mail merge field is not blank.
  /// </summary>
  IsNotBlank = 7
}
