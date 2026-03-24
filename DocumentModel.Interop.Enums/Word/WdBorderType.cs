namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of border to be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbordertype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdBorderType
{
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  DiagonalUp = -8,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  DiagonalDown = -7,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  Vertical = -6,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  Horizontal = -5,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  Right = -4,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  Bottom = -3,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  Left = -2,
  /// <summary>
  /// Specifies the type of border to be used.
  /// </summary>
  Top = -1
}
