namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the results of running a Document Inspector module.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocinspectorstatus?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoDocInspectorStatus))]
public enum DocInspectorStatus
{
  /// <summary>
  /// Indicates that the Document Inspector module returned no issues or errors.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocInspectorStatus.msoDocInspectorStatusDocOk))]
  DocOk,
  /// <summary>
  /// Indicates that the Document Inspector module found one or more occurrences of the search criteria.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocInspectorStatus.msoDocInspectorStatusIssueFound))]
  IssueFound,
  /// <summary>
  /// Indicates that the Document Inspector module returned an error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDocInspectorStatus.msoDocInspectorStatusError))]
  Error
}
