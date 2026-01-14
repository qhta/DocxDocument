namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a cell-level structured document tag in a Wordprocessing document.
/// This interface provides properties for SDT configuration and end character formatting, enabling advanced management and customization of structured document tags for table cells.
/// </summary>
public interface SdtCell: IElementCollection<ISdtCellContent>, ITableRowContent, ISdtCellContent
{
  
  /// <summary>
  /// Specifies the set of properties applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }
  
  /// <summary>
  /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}