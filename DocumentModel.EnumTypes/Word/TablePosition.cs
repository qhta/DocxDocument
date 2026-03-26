namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the relative position of a table in the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableposition?view=office-pia` for Office interop details.
/// </remarks>
public enum TablePosition
{
  /// <summary>
  /// At the top of the document.
  /// </summary>
  Top = -999999,
  /// <summary>
  /// Aligned to the left side of the document.
  /// </summary>
  Left = -999998,
  /// <summary>
  /// At the bottom of the document.
  /// </summary>
  Bottom = -999997,
  /// <summary>
  /// Aligned to the right side of the document.
  /// </summary>
  Right = -999996,
  /// <summary>
  /// Centered.
  /// </summary>
  Center = -999995,
  /// <summary>
  /// Placed inside a range.
  /// </summary>
  Inside = -999994,
  /// <summary>
  /// Placed outside a range.
  /// </summary>
  Outside = -999993
}
