
namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration applies to the Macintosh only and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindsortby?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFileFindSortBy")]
public enum FileFindSortBy
{
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbyAuthor")]
  Author = 1,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbyDateCreated")]
  DateCreated,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbyLastSavedBy")]
  LastSavedBy,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbyDateSaved")]
  DateSaved,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbyFileName")]
  FileName,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbySize")]
  Size,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [InteropEnumValue("msoFileFindSortbyTitle")]
  Title
}
