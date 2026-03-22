namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of ligatures applied to a font.
/// </summary>
public enum WdLigatures
{
  /// <summary>
  /// Does not apply any ligatures to the font.
  /// </summary>
  wdLigaturesNone = unchecked((int)0),
  /// <summary>
  /// Applies standard ligatures to the font. Standard ligatures are designed to enhance readability. Standard
  /// ligatures in Latin languages include "fi", "fl", and "ff", for example.
  /// </summary>
  wdLigaturesStandard = unchecked((int)1),
  /// <summary>
  /// Applies contextual ligatures to the font. Contextual ligatures are often designed to enhance readability, but
  /// may also be solely ornamental. Contextual ligatures may also be contextual alternates.
  /// </summary>
  wdLigaturesContextual = unchecked((int)2),
  /// <summary>
  /// Applies standard and contextual ligatures to the font.
  /// </summary>
  wdLigaturesStandardContextual = unchecked((int)3),
  /// <summary>
  /// Applies historical ligatures to the font. Historical ligatures are similar to standard ligatures in that they
  /// were originally intended to improve the readability of the font, but may look archaic to the modern reader.
  /// </summary>
  wdLigaturesHistorical = unchecked((int)4),
  /// <summary>
  /// Applies standard and historical ligatures to the font. public enum WdLigatures ﾉ Expand table
  /// </summary>
  wdLigaturesStandardHistorical = unchecked((int)5),
  /// <summary>
  /// Applies contextual and historical ligatures to the font. wdLigaturesStandardContextualHistorical7 Applies
  /// standard, contextual, and historical ligatures to the font.
  /// </summary>
  wdLigaturesContextualHistorical = unchecked((int)6),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  wdLigaturesStandardContextualHistorical = unchecked((int)7),
  /// <summary>
  /// Applies discretional ligatures to the font. Discretional ligatures are most often designed to be ornamental at
  /// the discretion of the type developer.
  /// </summary>
  wdLigaturesDiscretional = unchecked((int)8),
  /// <summary>
  /// Applies standard and discretional ligatures to the font. wdLigaturesContextualDiscretional10 Applies
  /// contextual and discretional ligatures to the font. wdLigaturesStandardContextualDiscretional11 Applies
  /// standard, contextual and discretional ligatures to the font.
  /// </summary>
  wdLigaturesStandardDiscretional = unchecked((int)9),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  wdLigaturesContextualDiscretional = unchecked((int)10),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  wdLigaturesStandardContextualDiscretional = unchecked((int)11),
  /// <summary>
  /// Applies historical and discretional ligatures to the font. wdLigaturesStandardHistoricalDiscretional13 Applies
  /// standard historical and discretional ligatures to the font. wdLigaturesContextualHistoricalDiscretional14
  /// Applies contextual, historical, and discretional ligatures to a font.
  /// </summary>
  wdLigaturesHistoricalDiscretional = unchecked((int)12),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  wdLigaturesStandardHistoricalDiscretional = unchecked((int)13),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  wdLigaturesContextualHistoricalDiscretional = unchecked((int)14),
  /// <summary>
  /// Applies all types of ligatures to the font.
  /// </summary>
  wdLigaturesAll = unchecked((int)15)
}
