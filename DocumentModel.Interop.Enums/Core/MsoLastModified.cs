
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the period of time to filter files by the date last modified. Used with the LastModified property of
/// the FileSearch object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolastmodified?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLastModified))]
public enum LastModified
{
  /// <summary>
  /// File last modified yesterday.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedYesterday))]
  Yesterday = 1,
  /// <summary>
  /// File last modified today.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedToday))]
  Today,
  /// <summary>
  /// File last modified last week.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedLastWeek))]
  LastWeek,
  /// <summary>
  /// File last modified this week.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedThisWeek))]
  ThisWeek,
  /// <summary>
  /// File last modified last month.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedLastMonth))]
  LastMonth,
  /// <summary>
  /// File last modified this month.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedThisMonth))]
  ThisMonth,
  /// <summary>
  /// File last modified any time.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLastModified.msoLastModifiedAnyTime))]
  AnyTime
}
