
namespace DocumentModel.Interop.Core;

/// <summary>
/// This enumeration applies to the Macintosh only and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindsortby?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoFileFindSortBy
{
  /// <summary>
  /// This member is for Macintosh only and should not be used. msoFileFindSortbyDateCreated2 This member is for
  /// Macintosh only and should not be used. msoFileFindSortbyLastSavedBy3 This member is for Macintosh only and
  /// should not be used. msoFileFindSortbyDateSaved4 This member is for Macintosh only and should not be used.
  /// msoFileFindSortbyFileName5 This member is for Macintosh only and should not be used.
  /// </summary>
  Author = 1,
  /// <summary>
  /// This enumeration applies to the Macintosh only and should not be used.
  /// </summary>
  DateCreated,
  /// <summary>
  /// This enumeration applies to the Macintosh only and should not be used.
  /// </summary>
  LastSavedBy,
  /// <summary>
  /// This enumeration applies to the Macintosh only and should not be used.
  /// </summary>
  DateSaved,
  /// <summary>
  /// This enumeration applies to the Macintosh only and should not be used.
  /// </summary>
  FileName,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  Size,
  /// <summary>
  /// This member is for Macintosh only and should not be used.
  /// </summary>
  Title
}
