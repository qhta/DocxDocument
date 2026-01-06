namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the columns layout in a section.
/// </summary>
public interface Columns: SectionPropertiesContent, ElementCollection<Column>
{
  /// <summary>
  ///   Equal IColumn Widths
  /// </summary>
  public bool? EqualWidth { get; set; }
  /// <summary>
  ///   Spacing Between Equal Width IColumns
  /// </summary>
  public Twips? Space { get; set; }
  /// <summary>
  ///   Number of Equal Width IColumns
  /// </summary>
  public int? ColumnCount { get; set; }
  /// <summary>
  ///   Draw Line Between IColumns
  /// </summary>
  public bool? Separator { get; set; }

}