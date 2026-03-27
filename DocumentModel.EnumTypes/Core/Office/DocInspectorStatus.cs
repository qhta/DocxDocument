namespace DocumentModel.Drawings;

/// <summary>
/// Represents the results of running a Document Inspector module.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocinspectorstatus?view=office-pia` for Office interop details.
/// </remarks>
public enum DocInspectorStatus
{
  /// <summary>
  /// Indicates that the Document Inspector module returned no issues or errors.
  /// </summary>
  DocOk,
  /// <summary>
  /// Indicates that the Document Inspector module found one or more occurrences of the search criteria.
  /// </summary>
  IssueFound,
  /// <summary>
  /// Indicates that the Document Inspector module returned an error.
  /// </summary>
  Error
}
