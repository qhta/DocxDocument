namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the columns layout in a section of a Wordprocessing document.
/// This interface provides properties for equal column widths, spacing, column count, and separator line, enabling advanced configuration of multi-column layouts within document sections.
/// </summary>
public interface TextColumns : SectionPropertiesContent, IElementCollection<TextColumn>
{

  /// <summary>
  /// Indicates whether columns have equal widths.
  /// </summary>
  public bool? EqualWidth { get; set; }

  /// <summary>
  /// Spacing between equal width columns, specified in twips.
  /// </summary>
  public Twips? Space { get; set; }

  /// <summary>
  /// Number of equal width columns in the section.
  /// </summary>
  public int? ColumnCount { get; set; }

  /// <summary>
  /// Indicates whether a line is drawn between columns.
  /// </summary>
  public bool? Separator { get; set; }
}