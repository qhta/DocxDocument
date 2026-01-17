namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the numbering format for a numbering definition in a WordprocessingML document.
/// This interface provides properties for specifying the standard numbering format type and a custom number format using XSLT syntax, enabling advanced customization of list and outline numbering styles.
/// </summary>
public class NumberingFormat : ModelElement<DXW.NumberingFormat>
{

  /// <summary>
  /// Standard numbering format type, specifying the built-in numbering style (e.g., decimal, roman, bullet).
  /// </summary>
  public NumberFormatKind? Type { get; set; }

  /// <summary>
  /// Custom number format using XSLT format attribute syntax. This format is used for all numbering in the parent object (e.g., Katakana numbering).
  /// </summary>
  public string? Custom { get; set; }
}