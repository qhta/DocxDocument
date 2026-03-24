namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of ligatures applied to a font.
/// </summary>
public enum WdLigatures
{
  /// <summary>
  /// Does not apply any ligatures to the font.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Applies standard ligatures to the font. Standard ligatures are designed to enhance readability. Standard
  /// ligatures in Latin languages include "fi", "fl", and "ff", for example.
  /// </summary>
  Standard = unchecked((int)1),
  /// <summary>
  /// Applies contextual ligatures to the font. Contextual ligatures are often designed to enhance readability, but
  /// may also be solely ornamental. Contextual ligatures may also be contextual alternates.
  /// </summary>
  Contextual = unchecked((int)2),
  /// <summary>
  /// Applies standard and contextual ligatures to the font.
  /// </summary>
  StandardContextual = unchecked((int)3),
  /// <summary>
  /// Applies historical ligatures to the font. Historical ligatures are similar to standard ligatures in that they
  /// were originally intended to improve the readability of the font, but may look archaic to the modern reader.
  /// </summary>
  Historical = unchecked((int)4),
  /// <summary>
  /// Applies standard and historical ligatures to the font. public enum WdLigatures ﾉ Expand table
  /// </summary>
  StandardHistorical = unchecked((int)5),
  /// <summary>
  /// Applies contextual and historical ligatures to the font. wdLigaturesStandardContextualHistorical7 Applies
  /// standard, contextual, and historical ligatures to the font.
  /// </summary>
  ContextualHistorical = unchecked((int)6),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardContextualHistorical = unchecked((int)7),
  /// <summary>
  /// Applies discretional ligatures to the font. Discretional ligatures are most often designed to be ornamental at
  /// the discretion of the type developer.
  /// </summary>
  Discretional = unchecked((int)8),
  /// <summary>
  /// Applies standard and discretional ligatures to the font. wdLigaturesContextualDiscretional10 Applies
  /// contextual and discretional ligatures to the font. wdLigaturesStandardContextualDiscretional11 Applies
  /// standard, contextual and discretional ligatures to the font.
  /// </summary>
  StandardDiscretional = unchecked((int)9),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  ContextualDiscretional = unchecked((int)10),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardContextualDiscretional = unchecked((int)11),
  /// <summary>
  /// Applies historical and discretional ligatures to the font. wdLigaturesStandardHistoricalDiscretional13 Applies
  /// standard historical and discretional ligatures to the font. wdLigaturesContextualHistoricalDiscretional14
  /// Applies contextual, historical, and discretional ligatures to a font.
  /// </summary>
  HistoricalDiscretional = unchecked((int)12),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardHistoricalDiscretional = unchecked((int)13),
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  ContextualHistoricalDiscretional = unchecked((int)14),
  /// <summary>
  /// Applies all types of ligatures to the font.
  /// </summary>
  All = unchecked((int)15)
}
