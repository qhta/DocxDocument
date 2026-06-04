namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of a dropped capital letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddropposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDropPosition")]
public enum DropPosition
{
  /// <summary>
  /// No dropped capital letter.
  /// </summary>
  [WordInteropEnumValue("wdDropNone")]
  None = 0,
  /// <summary>
  /// Dropped capital letter begins at the left margin.
  /// </summary>
  [WordInteropEnumValue("wdDropNormal")]
  Normal = 1,
  /// <summary>
  /// Dropped capital letter ends at the left margin.
  /// </summary>
  [WordInteropEnumValue("wdDropMargin")]
  Margin = 2
}
