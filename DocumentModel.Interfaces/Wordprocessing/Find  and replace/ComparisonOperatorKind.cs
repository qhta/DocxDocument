namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies comparison operators for numeric searches.
/// </summary>
public enum ComparisonOperatorKind
{
  /// <summary>Equal to</summary>
  Equal,
  /// <summary>Not equal to</summary>
  NotEqual,
  /// <summary>Less than</summary>
  LessThan,
  /// <summary>Greater than</summary>
  GreaterThan,
  /// <summary>Less than or equal to</summary>
  LessThanOrEqual,
  /// <summary>Greater than or equal to</summary>
  GreaterThanOrEqual
}