
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the period of time to filter files by the date last modified. Used with the LastModified property of
/// the FileSearch object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolastmodified?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLastModified")]
public enum LastModified
{
  /// <summary>
  /// File last modified yesterday.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedYesterday")]
  Yesterday = 1,
  /// <summary>
  /// File last modified today.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedToday")]
  Today,
  /// <summary>
  /// File last modified last week.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedLastWeek")]
  LastWeek,
  /// <summary>
  /// File last modified this week.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedThisWeek")]
  ThisWeek,
  /// <summary>
  /// File last modified last month.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedLastMonth")]
  LastMonth,
  /// <summary>
  /// File last modified this month.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedThisMonth")]
  ThisMonth,
  /// <summary>
  /// File last modified any time.
  /// </summary>
  [OfficeInteropEnumValue("msoLastModifiedAnyTime")]
  AnyTime
}
