namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents suggested filtering options for the list of document styles in a Wordprocessing document.
/// This interface provides properties for filtering by style type, usage, visibility, formatting, and alternate names, enabling advanced style pane customization and management.
/// </summary>
public class StylePaneFormatFilter: ModelElement
{
  /// <summary>
  /// Hexadecimal value representing the style pane format filter settings.
  /// </summary>
  public HexChar? Val { get; set; }

  /// <summary>
  /// Indicates whether all styles are included in the filter.
  /// </summary>
  public bool? AllStyles { get; set; }

  /// <summary>
  /// Indicates whether only custom styles are included in the filter.
  /// </summary>
  public bool? CustomStyles { get; set; }

  /// <summary>
  /// Indicates whether latent styles are included in the filter.
  /// </summary>
  public bool? LatentStyles { get; set; }

  /// <summary>
  /// Indicates whether only styles currently in use are included in the filter.
  /// </summary>
  public bool? StylesInUse { get; set; }

  /// <summary>
  /// Indicates whether heading styles are included in the filter.
  /// </summary>
  public bool? HeadingStyles { get; set; }

  /// <summary>
  /// Indicates whether numbering styles are included in the filter.
  /// </summary>
  public bool? NumberingStyles { get; set; }

  /// <summary>
  /// Indicates whether table styles are included in the filter.
  /// </summary>
  public bool? TableStyles { get; set; }

  /// <summary>
  /// Indicates whether direct formatting on runs is included in the filter.
  /// </summary>
  public bool? DirectFormattingOnRuns { get; set; }

  /// <summary>
  /// Indicates whether direct formatting on paragraphs is included in the filter.
  /// </summary>
  public bool? DirectFormattingOnParagraphs { get; set; }

  /// <summary>
  /// Indicates whether direct formatting on numbering is included in the filter.
  /// </summary>
  public bool? DirectFormattingOnNumbering { get; set; }

  /// <summary>
  /// Indicates whether direct formatting on tables is included in the filter.
  /// </summary>
  public bool? DirectFormattingOnTables { get; set; }

  /// <summary>
  /// Indicates whether clear formatting is included in the filter.
  /// </summary>
  public bool? ClearFormatting { get; set; }

  /// <summary>
  /// Indicates whether the top three heading styles are included in the filter.
  /// </summary>
  public bool? Top3HeadingStyles { get; set; }

  /// <summary>
  /// Indicates whether only visible styles are included in the filter.
  /// </summary>
  public bool? VisibleStyles { get; set; }

  /// <summary>
  /// Indicates whether alternate style names are included in the filter.
  /// </summary>
  public bool? AlternateStyleNames { get; set; }
}