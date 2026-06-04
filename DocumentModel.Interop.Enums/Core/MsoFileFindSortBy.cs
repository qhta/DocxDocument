
namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration applies to the Macintosh only and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindsortby?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFileFindSortBy")]
public enum FileFindSortBy
{
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbyAuthor")]
  Author = 1,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbyDateCreated")]
  DateCreated,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbyLastSavedBy")]
  LastSavedBy,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbyDateSaved")]
  DateSaved,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbyFileName")]
  FileName,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbySize")]
  Size,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  [OfficeInteropEnumValue("msoFileFindSortbyTitle")]
  Title
}
