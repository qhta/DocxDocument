namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of symbol to use as an enclosure.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenclosuretype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEnclosureType))]
public enum EnclosureType
{
  /// <summary>
  /// A circle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnclosureType.wdEnclosureCircle))]
  Circle = 0,
  /// <summary>
  /// A square.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnclosureType.wdEnclosureSquare))]
  Square = 1,
  /// <summary>
  /// A triangle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnclosureType.wdEnclosureTriangle))]
  Triangle = 2,
  /// <summary>
  /// A diamond.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnclosureType.wdEnclosureDiamond))]
  Diamond = 3
}
