
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
  Yesterday = 1,
  /// <summary>
  /// File last modified today.
  /// </summary>
  Today,
  /// <summary>
  /// File last modified last week.
  /// </summary>
  LastWeek,
  /// <summary>
  /// File last modified this week.
  /// </summary>
  ThisWeek,
  /// <summary>
  /// File last modified last month.
  /// </summary>
  LastMonth,
  /// <summary>
  /// File last modified this month.
  /// </summary>
  ThisMonth,
  /// <summary>
  /// File last modified any time.
  /// </summary>
  AnyTime
}
