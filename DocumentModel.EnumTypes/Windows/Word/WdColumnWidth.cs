namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent column width in reading layout, passed to and returned by the ColumnWidth property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcolumnwidth?view=office-pia` for Office interop details.
/// </remarks>
public enum WdColumnWidth
{
  /// <summary>
  /// Narrow column width.
  /// </summary>
  Narrow = 1,
  /// <summary>
  /// Default column width.
  /// </summary>
  Default = 2,
  /// <summary>
  /// Wide column width.
  /// </summary>
  Wide = 3
}
