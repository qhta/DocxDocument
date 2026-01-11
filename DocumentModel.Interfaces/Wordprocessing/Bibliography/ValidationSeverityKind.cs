namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the severity level of a validation issue.
/// </summary>
public enum ValidationSeverityKind
{
  /// <summary>Informational message</summary>
  Information,
  /// <summary>Warning - may cause formatting issues</summary>
  Warning,
  /// <summary>Error - required field missing or invalid</summary>
  Error,
  /// <summary>Critical error - source is unusable</summary>
  Critical
}