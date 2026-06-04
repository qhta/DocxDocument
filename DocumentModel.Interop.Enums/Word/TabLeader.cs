namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use as the leader with formatted tabs.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableader?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTabLeader")]
public enum TabLeader
{
  /// <summary>
  /// Spaces. default.
  /// </summary>
  [WordInteropEnumValue("wdTabLeaderSpaces")]
  Spaces = 0,
  /// <summary>
  /// Dots.
  /// </summary>
  [WordInteropEnumValue("wdTabLeaderDots")]
  Dots = 1,
  /// <summary>
  /// Dashes.
  /// </summary>
  [WordInteropEnumValue("wdTabLeaderDashes")]
  Dashes = 2,
  /// <summary>
  /// Double lines.
  /// </summary>
  [WordInteropEnumValue("wdTabLeaderLines")]
  Lines = 3,
  /// <summary>
  /// A heavy line.
  /// </summary>
  [WordInteropEnumValue("wdTabLeaderHeavy")]
  Heavy = 4,
  /// <summary>
  /// A middle dot.
  /// </summary>
  [WordInteropEnumValue("wdTabLeaderMiddleDot")]
  MiddleDot = 5
}
