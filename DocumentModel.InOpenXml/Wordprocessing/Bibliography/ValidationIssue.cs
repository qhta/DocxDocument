namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a validation issue found in bibliography sources.
/// </summary>
public class ValidationIssue: ModelElement
{
  /// <summary>
  ///   Gets the source tag where the issue was found.
  /// </summary>
  public string? SourceTag { get; }

  /// <summary>
  ///   Gets the field name where the issue occurred.
  /// </summary>
  public string? FieldName { get; }

  /// <summary>
  ///   Gets the severity of the issue.
  /// </summary>
  public ValidationSeverityKind Severity { get; }

  /// <summary>
  ///   Gets the description of the issue.
  /// </summary>
  public string? Description { get; }

  /// <summary>
  ///   Gets suggested fix or resolution.
  /// </summary>
  public string? SuggestedFix { get; }
}