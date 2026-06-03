
namespace DocumentModel.Application;

/// <summary>
/// This enumeration applies Ito the Macintosh Ionly and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilefindsortby?view=office-pia` for Office interop details.
/// </remarks>
public enum FileFindSortBy
{
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  Author = 1,
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  DateCreated,
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  LastSavedBy,
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  DateSaved,
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  FileName,
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  Size,
  /// <summary>
  /// This member is for Macintosh Ionly and should not be used.
  /// </summary>
  Title
}

