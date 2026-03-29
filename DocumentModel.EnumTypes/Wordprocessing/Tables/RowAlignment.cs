namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies alignment for the content in selected rows.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrowalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum RowAlignment
{
  /// <summary>
  /// Left aligned. default.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Right aligned.
  /// </summary>
  Right = 2
}
