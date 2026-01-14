namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents East Asian typography layout properties for a text run in WordprocessingML documents.
/// This interface provides options for two lines in one, bracket display, vertical text rotation, and compression, enabling advanced formatting for East Asian scripts.
/// </summary>
public class EastAsianLayout: ModelElement
{
  /// <summary>
  /// Identifier for the East Asian typography run, used to distinguish multiple layout effects within the same document.
  /// </summary>
  public Int32? Id { get; set; }

  /// <summary>
  /// Indicates whether two lines in one layout is applied, displaying text as two sub-lines within a single line.
  /// </summary>
  public bool? Combine { get; set; }

  /// <summary>
  /// Specifies the type of brackets to display around two lines in one layout.
  /// </summary>
  public CombineBracketKind? CombineBrackets { get; set; }

  /// <summary>
  /// Indicates whether horizontal text is rotated for vertical layout.
  /// </summary>
  public bool? Vertical { get; set; }

  /// <summary>
  /// Indicates whether rotated text is compressed to fit the line height in vertical layout.
  /// </summary>
  public bool? VerticalCompress { get; set; }
}