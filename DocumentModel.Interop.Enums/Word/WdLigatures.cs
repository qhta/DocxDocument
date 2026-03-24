namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of ligatures applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdligatures?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLigatures
{
  /// <summary>
  /// Does not apply any ligatures to the font.
  /// </summary>
  None = 0,
  /// <summary>
  /// Applies standard ligatures to the font. Standard ligatures are designed to enhance readability. Standard
  /// ligatures in Latin languages include "fi", "fl", and "ff", for example.
  /// </summary>
  Standard = 1,
  /// <summary>
  /// Applies contextual ligatures to the font. Contextual ligatures are often designed to enhance readability, but
  /// may also be solely ornamental. Contextual ligatures may also be contextual alternates.
  /// </summary>
  Contextual = 2,
  /// <summary>
  /// Applies standard and contextual ligatures to the font.
  /// </summary>
  StandardContextual = 3,
  /// <summary>
  /// Applies historical ligatures to the font. Historical ligatures are similar to standard ligatures in that they
  /// were originally intended to improve the readability of the font, but may look archaic to the modern reader.
  /// </summary>
  Historical = 4,
  /// <summary>
  /// Applies standard and historical ligatures to the font. public enum WdLigatures
  /// </summary>
  StandardHistorical = 5,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  ContextualHistorical = 6,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardContextualHistorical = 7,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  Discretional = 8,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardDiscretional = 9,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  ContextualDiscretional = 10,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardContextualDiscretional = 11,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  HistoricalDiscretional = 12,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  StandardHistoricalDiscretional = 13,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  ContextualHistoricalDiscretional = 14,
  /// <summary>
  /// Specifies the type of ligatures applied to a font.
  /// </summary>
  All = 15
}
