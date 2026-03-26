namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies tab alignment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdalignmenttabalignment?view=office-pia` for Office interop details.
/// </remarks>
public enum AlignmentTabAlignment
{
  /// <summary>
  /// Left-aligned tab.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Centered tab.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Right-aligned tab.
  /// </summary>
  Right = 2
}
