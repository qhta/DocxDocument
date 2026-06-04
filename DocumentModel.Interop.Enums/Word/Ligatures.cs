namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of ligatures applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdligatures?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLigatures))]
public enum OtLigatures
{
  /// <summary>
  /// Does not apply any ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesNone))]
  None = 0,
  /// <summary>
  /// Applies standard ligatures to the font. Standard ligatures are designed to enhance readability. Standard
  /// ligatures in Latin languages include "fi", "fl", and "ff", for example.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandard))]
  Standard = 1,
  /// <summary>
  /// Applies contextual ligatures to the font. Contextual ligatures are often designed to enhance readability, but
  /// may also be solely ornamental. Contextual ligatures may also be contextual alternates.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesContextual))]
  Contextual = 2,
  /// <summary>
  /// Applies standard and contextual ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandardContextual))]
  StandardContextual = 3,
  /// <summary>
  /// Applies historical ligatures to the font. Historical ligatures are similar to standard ligatures in that they
  /// were originally intended to improve the readability of the font, but may look archaic to the modern reader.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesHistorical))]
  Historical = 4,
  /// <summary>
  /// Applies standard and historical ligatures to the font. public enum Ligatures
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandardHistorical))]
  StandardHistorical = 5,
  /// <summary>
  /// Applies contextual and historical ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesContextualHistorical))]
  ContextualHistorical = 6,
  /// <summary>
  /// Applies standard, contextual, and historical ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandardContextualHistorical))]
  StandardContextualHistorical = 7,
  /// <summary>
  /// Applies discretional ligatures to the font. Discretional ligatures are most often designed to be ornamental at
  /// the discretion of the type developer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesDiscretional))]
  Discretional = 8,
  /// <summary>
  /// Applies standard and discretional ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandardDiscretional))]
  StandardDiscretional = 9,
  /// <summary>
  /// Applies contextual and discretional ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesContextualDiscretional))]
  ContextualDiscretional = 10,
  /// <summary>
  /// Applies standard, contextual and discretional ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandardContextualDiscretional))]
  StandardContextualDiscretional = 11,
  /// <summary>
  /// Applies historical and discretional ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesHistoricalDiscretional))]
  HistoricalDiscretional = 12,
  /// <summary>
  /// Applies standard historical and discretional ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesStandardHistoricalDiscretional))]
  StandardHistoricalDiscretional = 13,
  /// <summary>
  /// Applies contextual, historical, and discretional ligatures to a font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesContextualHistoricalDiscretional))]
  ContextualHistoricalDiscretional = 14,
  /// <summary>
  /// Applies all types of ligatures to the font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLigatures.wdLigaturesAll))]
  All = 15
}
