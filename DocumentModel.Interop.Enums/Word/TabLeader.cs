namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character to use as the leader with formatted tabs.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableader?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTabLeader))]
public enum TabLeader
{
  /// <summary>
  /// Spaces. default.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabLeader.wdTabLeaderSpaces))]
  Spaces = 0,
  /// <summary>
  /// Dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabLeader.wdTabLeaderDots))]
  Dots = 1,
  /// <summary>
  /// Dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabLeader.wdTabLeaderDashes))]
  Dashes = 2,
  /// <summary>
  /// Double lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabLeader.wdTabLeaderLines))]
  Lines = 3,
  /// <summary>
  /// A heavy line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabLeader.wdTabLeaderHeavy))]
  Heavy = 4,
  /// <summary>
  /// A middle dot.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTabLeader.wdTabLeaderMiddleDot))]
  MiddleDot = 5
}
