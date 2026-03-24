namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the page size for a custom mailing label.
/// </summary>
public enum WdCustomLabelPageSize
{
  /// <summary>
  /// Standard letter portrait label dimensions.
  /// </summary>
  Letter = unchecked((int)0),
  /// <summary>
  /// Standard letter landscape label dimensions.
  /// </summary>
  LetterLS = unchecked((int)1),
  /// <summary>
  /// A4 portrait label dimensions.
  /// </summary>
  A4 = unchecked((int)2),
  /// <summary>
  /// A4 landscape label dimensions.
  /// </summary>
  A4LS = unchecked((int)3),
  /// <summary>
  /// A5 portrait label dimensions.
  /// </summary>
  A5 = unchecked((int)4),
  /// <summary>
  /// A5 landscape label dimensions.
  /// </summary>
  A5LS = unchecked((int)5),
  /// <summary>
  /// B5 label dimensions.
  /// </summary>
  B5 = unchecked((int)6),
  /// <summary>
  /// Mini label dimensions.
  /// </summary>
  Mini = unchecked((int)7),
  /// <summary>
  /// Fanfold label dimensions.
  /// </summary>
  Fanfold = unchecked((int)8),
  /// <summary>
  /// Half-sheet portrait label dimensions.
  /// </summary>
  VertHalfSheet = unchecked((int)9),
  /// <summary>
  /// Half-sheet landscape label dimensions.
  /// [System.Runtime.InteropServices.Guid("B116B479-488C-3D69-BFBE-A64DD14F3BB9")] public enum
  /// WdCustomLabelPageSize ﾉ Expand table
  /// </summary>
  VertHalfSheetLS = unchecked((int)10),
  /// <summary>
  /// Higaki portrait label dimensions.
  /// </summary>
  Higaki = unchecked((int)11),
  /// <summary>
  /// Higaki landscape label dimensions.
  /// </summary>
  HigakiLS = unchecked((int)12),
  /// <summary>
  /// B4 JIS label dimensions.
  /// </summary>
  B4JIS = unchecked((int)13)
}
