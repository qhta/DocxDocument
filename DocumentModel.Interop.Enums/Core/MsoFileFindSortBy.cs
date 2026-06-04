
namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration applies to the Macintosh only and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindsortby?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileFindSortBy))]
public enum FileFindSortBy
{
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbyAuthor))]
  Author = 1,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbyDateCreated))]
  DateCreated,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbyLastSavedBy))]
  LastSavedBy,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbyDateSaved))]
  DateSaved,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbyFileName))]
  FileName,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbySize))]
  Size,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileFindSortBy.msoFileFindSortbyTitle))]
  Title
}
