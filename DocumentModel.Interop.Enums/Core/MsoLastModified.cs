
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the period of time to filter files by the date last modified. Used with the LastModified property of
/// the FileSearch object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolastmodified?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLastModified")]
public enum LastModified
{
  /// <summary>
  /// File last modified yesterday.
  /// </summary>
  [InteropEnumValue("msoLastModifiedYesterday")]
  Yesterday = 1,
  /// <summary>
  /// File last modified today.
  /// </summary>
  [InteropEnumValue("msoLastModifiedToday")]
  Today,
  /// <summary>
  /// File last modified last week.
  /// </summary>
  [InteropEnumValue("msoLastModifiedLastWeek")]
  LastWeek,
  /// <summary>
  /// File last modified this week.
  /// </summary>
  [InteropEnumValue("msoLastModifiedThisWeek")]
  ThisWeek,
  /// <summary>
  /// File last modified last month.
  /// </summary>
  [InteropEnumValue("msoLastModifiedLastMonth")]
  LastMonth,
  /// <summary>
  /// File last modified this month.
  /// </summary>
  [InteropEnumValue("msoLastModifiedThisMonth")]
  ThisMonth,
  /// <summary>
  /// File last modified any time.
  /// </summary>
  [InteropEnumValue("msoLastModifiedAnyTime")]
  AnyTime
}
