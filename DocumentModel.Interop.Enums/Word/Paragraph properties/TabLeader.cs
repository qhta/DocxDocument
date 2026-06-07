namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use as the leader with formatted tabs.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableader?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTabLeader")]
public enum TabLeader
{
  /// <summary>
  /// Spaces. default.
  /// </summary>
  [InteropEnumValue("wdTabLeaderSpaces")]
  Spaces = 0,
  /// <summary>
  /// Dots.
  /// </summary>
  [InteropEnumValue("wdTabLeaderDots")]
  Dots = 1,
  /// <summary>
  /// Dashes.
  /// </summary>
  [InteropEnumValue("wdTabLeaderDashes")]
  Dashes = 2,
  /// <summary>
  /// Double lines.
  /// </summary>
  [InteropEnumValue("wdTabLeaderLines")]
  Lines = 3,
  /// <summary>
  /// A heavy line.
  /// </summary>
  [InteropEnumValue("wdTabLeaderHeavy")]
  Heavy = 4,
  /// <summary>
  /// A middle dot.
  /// </summary>
  [InteropEnumValue("wdTabLeaderMiddleDot")]
  MiddleDot = 5
}
