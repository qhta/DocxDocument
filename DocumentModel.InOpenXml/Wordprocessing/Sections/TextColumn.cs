namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single column definition in a section of a Wordprocessing document.
/// This interface provides properties for column width and spacing before the following column, enabling advanced configuration of multi-column layouts within document sections.
/// </summary>
public interface TextColumn: ICollectionItem
{
  /// <summary>
  /// Column width, specifying the width of the column.
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  /// Space before the following column, specifying the spacing between columns.
  /// </summary>
  public string? Space { get; set; }
}