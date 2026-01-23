namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents style conditional table formatting properties for a table in a Wordprocessing document.
/// This class provides properties for conditional formatting type, paragraph and run properties, and conditional formatting for tables, rows, and cells, enabling advanced styling and formatting options based on table style rules.
/// </summary>
public class TableStyleProperties: ModelElement<DXW.TableStyleProperties>
{
  
  /// <summary>
  /// Table style conditional formatting type, specifying the override kind for conditional formatting.
  /// </summary>
  public TableStyleOverrideKind? Type { get; set; }
  
  /// <summary>
  /// Table style conditional formatting paragraph properties, specifying formatting for paragraphs within the table.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties { get; set; }
  
  /// <summary>
  /// Table style conditional formatting run properties, specifying formatting for text runs within the table.
  /// </summary>
  public TableStyleRunProperties? TableStyleRunProperties { get; set; }
  
  /// <summary>
  /// Table style conditional formatting table properties, specifying formatting for the table as a whole.
  /// </summary>
  public TableStyleConditionalTableProperties? TableStyleConditionalTableProperties { get; set; }
  
  /// <summary>
  /// Table style conditional formatting table row properties, specifying formatting for individual rows.
  /// </summary>
  public TableStyleConditionalRowProperties? TableStyleConditionalRowProperties { get; set; }
  
  /// <summary>
  /// Table style conditional formatting table cell properties, specifying formatting for individual cells.
  /// </summary>
  public TableStyleConditionalCellProperties? TableStyleConditionalCellProperties { get; set; }
}