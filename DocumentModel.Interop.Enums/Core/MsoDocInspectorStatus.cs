namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the results of running a Document Inspector module.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocinspectorstatus?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoDocInspectorStatus
{
  /// <summary>
  /// Indicates that the Document Inspector module returned no issues or errors. msoDocInspectorStatusIssueFound1
  /// Indicates that the Document Inspector module found one or more occurrences of the search criteria.
  /// </summary>
  DocOk,
  /// <summary>
  /// Represents the results of running a Document Inspector module.
  /// </summary>
  IssueFound,
  /// <summary>
  /// Indicates that the Document Inspector module returned an error.
  /// </summary>
  Error
}
