namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the predefined format to apply to a table.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTableFormat")]
public enum TableFormat
{
  /// <summary>
  /// No formatting.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatNone")]
  None = 0,
  /// <summary>
  /// Simple format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatSimple1")]
  Simple1 = 1,
  /// <summary>
  /// Simple format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatSimple2")]
  Simple2 = 2,
  /// <summary>
  /// Simple format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatSimple3")]
  Simple3 = 3,
  /// <summary>
  /// Classic format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatClassic1")]
  Classic1 = 4,
  /// <summary>
  /// Classic format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatClassic2")]
  Classic2 = 5,
  /// <summary>
  /// Classic format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatClassic3")]
  Classic3 = 6,
  /// <summary>
  /// Classic format number 4.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatClassic4")]
  Classic4 = 7,
  /// <summary>
  /// Colorful format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColorful1")]
  Colorful1 = 8,
  /// <summary>
  /// Colorful format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColorful2")]
  Colorful2 = 9,
  /// <summary>
  /// Colorful format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColorful3")]
  Colorful3 = 10,
  /// <summary>
  /// Columns format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColumns1")]
  Columns1 = 11,
  /// <summary>
  /// Columns format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColumns2")]
  Columns2 = 12,
  /// <summary>
  /// Columns format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColumns3")]
  Columns3 = 13,
  /// <summary>
  /// Columns format number 4.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColumns4")]
  Columns4 = 14,
  /// <summary>
  /// Columns format number 5.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatColumns5")]
  Columns5 = 15,
  /// <summary>
  /// Grid format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid1")]
  Grid1 = 16,
  /// <summary>
  /// Grid format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid2")]
  Grid2 = 17,
  /// <summary>
  /// Grid format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid3")]
  Grid3 = 18,
  /// <summary>
  /// Grid format number 4.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid4")]
  Grid4 = 19,
  /// <summary>
  /// Grid format number 5.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid5")]
  Grid5 = 20,
  /// <summary>
  /// Grid format number 6.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid6")]
  Grid6 = 21,
  /// <summary>
  /// Grid format number 7.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid7")]
  Grid7 = 22,
  /// <summary>
  /// Grid format number 8.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatGrid8")]
  Grid8 = 23,
  /// <summary>
  /// List format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList1")]
  List1 = 24,
  /// <summary>
  /// List format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList2")]
  List2 = 25,
  /// <summary>
  /// List format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList3")]
  List3 = 26,
  /// <summary>
  /// List format number 4.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList4")]
  List4 = 27,
  /// <summary>
  /// List format number 5.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList5")]
  List5 = 28,
  /// <summary>
  /// List format number 6.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList6")]
  List6 = 29,
  /// <summary>
  /// List format number 7.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList7")]
  List7 = 30,
  /// <summary>
  /// List format number 8.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatList8")]
  List8 = 31,
  /// <summary>
  /// Specifies the predefined format to apply to a table.
  /// </summary>
  [WordInteropEnumValue("wdTableFormat3DEffects1")]
  ThreeDEffects1 = 32,
  /// <summary>
  /// Specifies the predefined format to apply to a table.
  /// </summary>
  [WordInteropEnumValue("wdTableFormat3DEffects2")]
  ThreeDEffects2 = 33,
  /// <summary>
  /// Specifies the predefined format to apply to a table.
  /// </summary>
  [WordInteropEnumValue("wdTableFormat3DEffects3")]
  ThreeDEffects3 = 34,
  /// <summary>
  /// Contemporary format.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatContemporary")]
  Contemporary = 35,
  /// <summary>
  /// Elegant format.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatElegant")]
  Elegant = 36,
  /// <summary>
  /// Professional format.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatProfessional")]
  Professional = 37,
  /// <summary>
  /// Subtle format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatSubtle1")]
  Subtle1 = 38,
  /// <summary>
  /// Subtle format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatSubtle2")]
  Subtle2 = 39,
  /// <summary>
  /// Web format number 1.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatWeb1")]
  Web1 = 40,
  /// <summary>
  /// Web format number 2.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatWeb2")]
  Web2 = 41,
  /// <summary>
  /// Web format number 3.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatWeb3")]
  Web3 = 42
}
