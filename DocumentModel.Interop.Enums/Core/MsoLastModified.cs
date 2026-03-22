
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the period of time to filter files by the date last modified. Used with the LastModified property of
/// the FileSearch object.
/// </summary>
public enum MsoLastModified
{
  /// <summary>
  /// File last modified yesterday.
  /// </summary>
  msoLastModifiedYesterday = 1,
  /// <summary>
  /// File last modified today.
  /// </summary>
  msoLastModifiedToday,
  /// <summary>
  /// File last modified last week.
  /// </summary>
  msoLastModifiedLastWeek,
  /// <summary>
  /// File last modified this week.
  /// </summary>
  msoLastModifiedThisWeek,
  /// <summary>
  /// File last modified last month.
  /// </summary>
  msoLastModifiedLastMonth,
  /// <summary>
  /// File last modified this month.
  /// </summary>
  msoLastModifiedThisMonth,
  /// <summary>
  /// File last modified any time.
  /// </summary>
  msoLastModifiedAnyTime
}
