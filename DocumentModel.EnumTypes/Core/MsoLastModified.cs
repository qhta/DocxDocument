
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the period of time to filter files by the date last modified. Used with the LastModified property of
/// the FileSearch object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolastmodified?view=office-pia` for Office interop details.
/// </remarks>
public enum LastModified
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
