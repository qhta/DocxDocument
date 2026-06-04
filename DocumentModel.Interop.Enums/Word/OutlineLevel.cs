namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the outline level to apply to a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoutlinelevel?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOutlineLevel))]
public enum OutlineLevel
{
  /// <summary>
  /// Specifies the outline level 1 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel1))]
  Level1 = 1,
  /// <summary>
  /// Specifies the outline level 2 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel2))]
  Level2 = 2,
  /// <summary>
  /// Specifies the outline level 3 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel3))]
  Level3 = 3,
  /// <summary>
  /// Specifies the outline level 4 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel4))]
  Level4 = 4,
  /// <summary>
  /// Specifies the outline level 5 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel5))]
  Level5 = 5,
  /// <summary>
  /// Specifies the outline level 6 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel6))]
  Level6 = 6,
  /// <summary>
  /// Specifies the outline level 7 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel7))]
  Level7 = 7,
  /// <summary>
  /// Specifies the outline level 8 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel8))]
  Level8 = 8,
  /// <summary>
  /// Specifies the outline level 9 to apply to a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevel9))]
  Level9 = 9,
  /// <summary>
  /// No outline level.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOutlineLevel.wdOutlineLevelBodyText))]
  BodyText = 10
}
