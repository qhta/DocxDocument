namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of symbol to use as an enclosure.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenclosuretype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdEnclosureType")]
public enum EnclosureType
{
  /// <summary>
  /// A circle.
  /// </summary>
  [InteropEnumValue("wdEnclosureCircle")]
  Circle = 0,
  /// <summary>
  /// A square.
  /// </summary>
  [InteropEnumValue("wdEnclosureSquare")]
  Square = 1,
  /// <summary>
  /// A triangle.
  /// </summary>
  [InteropEnumValue("wdEnclosureTriangle")]
  Triangle = 2,
  /// <summary>
  /// A diamond.
  /// </summary>
  [InteropEnumValue("wdEnclosureDiamond")]
  Diamond = 3
}
