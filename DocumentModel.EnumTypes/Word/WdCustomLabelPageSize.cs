namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the page size for a custom mailing label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcustomlabelpagesize?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCustomLabelPageSize
{
  /// <summary>
  /// Standard letter portrait label dimensions.
  /// </summary>
  Letter = 0,
  /// <summary>
  /// Standard letter landscape label dimensions.
  /// </summary>
  LetterLS = 1,
  /// <summary>
  /// A4 portrait label dimensions.
  /// </summary>
  A4 = 2,
  /// <summary>
  /// A4 landscape label dimensions.
  /// </summary>
  A4LS = 3,
  /// <summary>
  /// A5 portrait label dimensions.
  /// </summary>
  A5 = 4,
  /// <summary>
  /// A5 landscape label dimensions.
  /// </summary>
  A5LS = 5,
  /// <summary>
  /// B5 label dimensions.
  /// </summary>
  B5 = 6,
  /// <summary>
  /// Mini label dimensions.
  /// </summary>
  Mini = 7,
  /// <summary>
  /// Fanfold label dimensions.
  /// </summary>
  Fanfold = 8,
  /// <summary>
  /// Half-sheet portrait label dimensions.
  /// </summary>
  VertHalfSheet = 9,
  /// <summary>
  /// Half-sheet landscape label dimensions.
  /// </summary>
  VertHalfSheetLS = 10,
  /// <summary>
  /// Higaki portrait label dimensions.
  /// </summary>
  Higaki = 11,
  /// <summary>
  /// Higaki landscape label dimensions.
  /// </summary>
  HigakiLS = 12,
  /// <summary>
  /// B4 JIS label dimensions.
  /// </summary>
  B4JIS = 13
}
