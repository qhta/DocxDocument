namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment of a horizontal line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontallinealignment?view=office-pia` for Office interop details.
/// </remarks>
public enum WdHorizontalLineAlignment
{
  /// <summary>
  /// Aligned to the left.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Aligned to the right.
  /// </summary>
  Right = 2
}
