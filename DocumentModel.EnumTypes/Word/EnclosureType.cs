namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of symbol to use as an enclosure.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenclosuretype?view=office-pia` for Office interop details.
/// </remarks>
public enum EnclosureType
{
  /// <summary>
  /// A circle.
  /// </summary>
  Circle = 0,
  /// <summary>
  /// A square.
  /// </summary>
  Square = 1,
  /// <summary>
  /// A triangle.
  /// </summary>
  Triangle = 2,
  /// <summary>
  /// A diamond.
  /// </summary>
  Diamond = 3
}
