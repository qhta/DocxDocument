namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the position of a dropped capital letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddropposition?view=office-pia` for Office interop details.
/// </remarks>
public enum DropPosition
{
  /// <summary>
  /// No dropped capital letter.
  /// </summary>
  None = 0,
  /// <summary>
  /// Dropped capital letter begins at the left margin.
  /// </summary>
  Normal = 1,
  /// <summary>
  /// Dropped capital letter ends at the left margin.
  /// </summary>
  Margin = 2
}
