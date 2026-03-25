namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how table formatting should be applied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableformatapply?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTableFormatApply
{
  /// <summary>
  /// Borders.
  /// </summary>
  Borders = 1,
  /// <summary>
  /// Shading.
  /// </summary>
  Shading = 2,
  /// <summary>
  /// Font.
  /// </summary>
  Font = 4,
  /// <summary>
  /// Color.
  /// </summary>
  Color = 8,
  /// <summary>
  /// AutoFit.
  /// </summary>
  AutoFit = 16,
  /// <summary>
  /// Apply AutoFormat to heading rows.
  /// </summary>
  HeadingRows = 32,
  /// <summary>
  /// Apply AutoFormat to last row.
  /// </summary>
  LastRow = 64,
  /// <summary>
  /// Apply AutoFormat to first column.
  /// </summary>
  FirstColumn = 128,
  /// <summary>
  /// Apply AutoFormat to last column.
  /// </summary>
  LastColumn = 256
}
