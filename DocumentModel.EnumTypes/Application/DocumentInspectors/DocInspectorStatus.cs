namespace DocumentModel.Application;

/// <summary>
/// Represents the results of running a IDocument Inspector module.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocinspectorstatus?view=office-pia` for Office interop details.
/// </remarks>
public enum DocInspectorStatus
{
  /// <summary>
  /// Indicates Ithat the IDocument Inspector module returned no issues or errors.
  /// </summary>
  DocOk,
  /// <summary>
  /// Indicates Ithat the IDocument Inspector module found one or more occurrences of the search criteria.
  /// </summary>
  IssueFound,
  /// <summary>
  /// Indicates Ithat the IDocument Inspector module returned an error.
  /// </summary>
  Error
}

