namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of ligatures applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdligatures?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLigatures")]
public enum OtLigatures
{
  /// <summary>
  /// Does not apply any ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesNone")]
  None = 0,
  /// <summary>
  /// Applies standard ligatures to the font. Standard ligatures are designed to enhance readability. Standard
  /// ligatures in Latin languages include "fi", "fl", and "ff", for example.
  /// </summary>
  [InteropEnumValue("wdLigaturesStandard")]
  Standard = 1,
  /// <summary>
  /// Applies contextual ligatures to the font. Contextual ligatures are often designed to enhance readability, but
  /// may also be solely ornamental. Contextual ligatures may also be contextual alternates.
  /// </summary>
  [InteropEnumValue("wdLigaturesContextual")]
  Contextual = 2,
  /// <summary>
  /// Applies standard and contextual ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesStandardContextual")]
  StandardContextual = 3,
  /// <summary>
  /// Applies historical ligatures to the font. Historical ligatures are similar to standard ligatures in that they
  /// were originally intended to improve the readability of the font, but may look archaic to the modern reader.
  /// </summary>
  [InteropEnumValue("wdLigaturesHistorical")]
  Historical = 4,
  /// <summary>
  /// Applies standard and historical ligatures to the font. public enum Ligatures
  /// </summary>
  [InteropEnumValue("wdLigaturesStandardHistorical")]
  StandardHistorical = 5,
  /// <summary>
  /// Applies contextual and historical ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesContextualHistorical")]
  ContextualHistorical = 6,
  /// <summary>
  /// Applies standard, contextual, and historical ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesStandardContextualHistorical")]
  StandardContextualHistorical = 7,
  /// <summary>
  /// Applies discretional ligatures to the font. Discretional ligatures are most often designed to be ornamental at
  /// the discretion of the type developer.
  /// </summary>
  [InteropEnumValue("wdLigaturesDiscretional")]
  Discretional = 8,
  /// <summary>
  /// Applies standard and discretional ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesStandardDiscretional")]
  StandardDiscretional = 9,
  /// <summary>
  /// Applies contextual and discretional ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesContextualDiscretional")]
  ContextualDiscretional = 10,
  /// <summary>
  /// Applies standard, contextual and discretional ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesStandardContextualDiscretional")]
  StandardContextualDiscretional = 11,
  /// <summary>
  /// Applies historical and discretional ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesHistoricalDiscretional")]
  HistoricalDiscretional = 12,
  /// <summary>
  /// Applies standard historical and discretional ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesStandardHistoricalDiscretional")]
  StandardHistoricalDiscretional = 13,
  /// <summary>
  /// Applies contextual, historical, and discretional ligatures to a font.
  /// </summary>
  [InteropEnumValue("wdLigaturesContextualHistoricalDiscretional")]
  ContextualHistoricalDiscretional = 14,
  /// <summary>
  /// Applies all types of ligatures to the font.
  /// </summary>
  [InteropEnumValue("wdLigaturesAll")]
  All = 15
}
