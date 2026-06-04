namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of symbol to use as an enclosure.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenclosuretype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdEnclosureType")]
public enum EnclosureType
{
  /// <summary>
  /// A circle.
  /// </summary>
  [WordInteropEnumValue("wdEnclosureCircle")]
  Circle = 0,
  /// <summary>
  /// A square.
  /// </summary>
  [WordInteropEnumValue("wdEnclosureSquare")]
  Square = 1,
  /// <summary>
  /// A triangle.
  /// </summary>
  [WordInteropEnumValue("wdEnclosureTriangle")]
  Triangle = 2,
  /// <summary>
  /// A diamond.
  /// </summary>
  [WordInteropEnumValue("wdEnclosureDiamond")]
  Diamond = 3
}
