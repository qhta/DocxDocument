namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the predefined format to apply to a table.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTableFormat))]
public enum TableFormat
{
  /// <summary>
  /// No formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatNone))]
  None = 0,
  /// <summary>
  /// Simple format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatSimple1))]
  Simple1 = 1,
  /// <summary>
  /// Simple format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatSimple2))]
  Simple2 = 2,
  /// <summary>
  /// Simple format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatSimple3))]
  Simple3 = 3,
  /// <summary>
  /// Classic format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatClassic1))]
  Classic1 = 4,
  /// <summary>
  /// Classic format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatClassic2))]
  Classic2 = 5,
  /// <summary>
  /// Classic format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatClassic3))]
  Classic3 = 6,
  /// <summary>
  /// Classic format number 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatClassic4))]
  Classic4 = 7,
  /// <summary>
  /// Colorful format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColorful1))]
  Colorful1 = 8,
  /// <summary>
  /// Colorful format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColorful2))]
  Colorful2 = 9,
  /// <summary>
  /// Colorful format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColorful3))]
  Colorful3 = 10,
  /// <summary>
  /// Columns format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColumns1))]
  Columns1 = 11,
  /// <summary>
  /// Columns format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColumns2))]
  Columns2 = 12,
  /// <summary>
  /// Columns format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColumns3))]
  Columns3 = 13,
  /// <summary>
  /// Columns format number 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColumns4))]
  Columns4 = 14,
  /// <summary>
  /// Columns format number 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatColumns5))]
  Columns5 = 15,
  /// <summary>
  /// Grid format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid1))]
  Grid1 = 16,
  /// <summary>
  /// Grid format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid2))]
  Grid2 = 17,
  /// <summary>
  /// Grid format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid3))]
  Grid3 = 18,
  /// <summary>
  /// Grid format number 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid4))]
  Grid4 = 19,
  /// <summary>
  /// Grid format number 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid5))]
  Grid5 = 20,
  /// <summary>
  /// Grid format number 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid6))]
  Grid6 = 21,
  /// <summary>
  /// Grid format number 7.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid7))]
  Grid7 = 22,
  /// <summary>
  /// Grid format number 8.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatGrid8))]
  Grid8 = 23,
  /// <summary>
  /// List format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList1))]
  List1 = 24,
  /// <summary>
  /// List format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList2))]
  List2 = 25,
  /// <summary>
  /// List format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList3))]
  List3 = 26,
  /// <summary>
  /// List format number 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList4))]
  List4 = 27,
  /// <summary>
  /// List format number 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList5))]
  List5 = 28,
  /// <summary>
  /// List format number 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList6))]
  List6 = 29,
  /// <summary>
  /// List format number 7.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList7))]
  List7 = 30,
  /// <summary>
  /// List format number 8.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatList8))]
  List8 = 31,
  /// <summary>
  /// Specifies the predefined format to apply to a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormat3DEffects1))]
  ThreeDEffects1 = 32,
  /// <summary>
  /// Specifies the predefined format to apply to a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormat3DEffects2))]
  ThreeDEffects2 = 33,
  /// <summary>
  /// Specifies the predefined format to apply to a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormat3DEffects3))]
  ThreeDEffects3 = 34,
  /// <summary>
  /// Contemporary format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatContemporary))]
  Contemporary = 35,
  /// <summary>
  /// Elegant format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatElegant))]
  Elegant = 36,
  /// <summary>
  /// Professional format.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatProfessional))]
  Professional = 37,
  /// <summary>
  /// Subtle format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatSubtle1))]
  Subtle1 = 38,
  /// <summary>
  /// Subtle format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatSubtle2))]
  Subtle2 = 39,
  /// <summary>
  /// Web format number 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatWeb1))]
  Web1 = 40,
  /// <summary>
  /// Web format number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatWeb2))]
  Web2 = 41,
  /// <summary>
  /// Web format number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormat.wdTableFormatWeb3))]
  Web3 = 42
}
