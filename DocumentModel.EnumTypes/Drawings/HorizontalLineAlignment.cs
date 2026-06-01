namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the alignment of a horizontal line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontallinealignment?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum HorizontalLineAlignment
{
  /// <summary>
  /// Aligned Ito the left.
  /// </summary>
  Left = 0,
  /// <summary>
  /// Centered.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Aligned Ito the right.
  /// </summary>
  Right = 2
}

