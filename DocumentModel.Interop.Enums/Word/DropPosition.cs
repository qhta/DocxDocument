namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a dropped capital letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddropposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDropPosition")]
public enum DropPosition
{
  /// <summary>
  /// No dropped capital letter.
  /// </summary>
  [InteropEnumValue("wdDropNone")]
  None = 0,
  /// <summary>
  /// Dropped capital letter begins at the left margin.
  /// </summary>
  [InteropEnumValue("wdDropNormal")]
  Normal = 1,
  /// <summary>
  /// Dropped capital letter ends at the left margin.
  /// </summary>
  [InteropEnumValue("wdDropMargin")]
  Margin = 2
}
