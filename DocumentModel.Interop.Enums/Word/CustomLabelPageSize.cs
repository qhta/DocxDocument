namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the page size for a custom mailing label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcustomlabelpagesize?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize))]
public enum CustomLabelPageSize
{
  /// <summary>
  /// Standard letter portrait label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelLetter))]
  Letter = 0,
  /// <summary>
  /// Standard letter landscape label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelLetterLS))]
  LetterLS = 1,
  /// <summary>
  /// A4 portrait label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelA4))]
  A4 = 2,
  /// <summary>
  /// A4 landscape label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelA4LS))]
  A4LS = 3,
  /// <summary>
  /// A5 portrait label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelA5))]
  A5 = 4,
  /// <summary>
  /// A5 landscape label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelA5LS))]
  A5LS = 5,
  /// <summary>
  /// B5 label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelB5))]
  B5 = 6,
  /// <summary>
  /// Mini label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelMini))]
  Mini = 7,
  /// <summary>
  /// Fanfold label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelFanfold))]
  Fanfold = 8,
  /// <summary>
  /// Half-sheet portrait label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelVertHalfSheet))]
  VertHalfSheet = 9,
  /// <summary>
  /// Half-sheet landscape label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelVertHalfSheetLS))]
  VertHalfSheetLS = 10,
  /// <summary>
  /// Higaki portrait label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelHigaki))]
  Higaki = 11,
  /// <summary>
  /// Higaki landscape label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelHigakiLS))]
  HigakiLS = 12,
  /// <summary>
  /// B4 JIS label dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCustomLabelPageSize.wdCustomLabelB4JIS))]
  B4JIS = 13
}
