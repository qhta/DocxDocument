namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the alignment to apply to page numbers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagenumberalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum PageNumberAlignment
{
  /// <summary>
  /// Left-aligned.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Right-aligned.
  /// </summary>
  Right = 2,
  /// <summary>
  /// Left-aligned just inside the footer.
  /// </summary>
  Inside = 3,
  /// <summary>
  /// Right-aligned just outside the footer.
  /// </summary>
  Outside = 4
}
