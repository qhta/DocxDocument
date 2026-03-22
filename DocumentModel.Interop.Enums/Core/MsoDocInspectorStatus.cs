namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the results of running a Document Inspector module.
/// </summary>
public enum MsoDocInspectorStatus
{
  /// <summary>
  /// Indicates that the Document Inspector module returned no issues or errors. msoDocInspectorStatusIssueFound1
  /// Indicates that the Document Inspector module found one or more occurrences of the search criteria.
  /// </summary>
  msoDocInspectorStatusDocOk,
  /// <summary>
  /// Represents the results of running a Document Inspector module.
  /// </summary>
  msoDocInspectorStatusIssueFound,
  /// <summary>
  /// Indicates that the Document Inspector module returned an error.
  /// </summary>
  msoDocInspectorStatusError
}
