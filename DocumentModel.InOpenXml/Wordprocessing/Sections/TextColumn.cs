namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single column definition in a section of a Wordprocessing document.
/// This class provides properties for column width and spacing before the following column, enabling advanced configuration of multi-column layouts within document sections.
/// </summary>
[OpenXmlType(typeof(DXW.Column))]
public class TextColumn: ModelElement<DXW.Column>
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