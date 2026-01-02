namespace DocumentModel.Wordprocessing;

/// <summary>
///   Cell-Level Structured Document Tag.
/// </summary>
public class SdtCell: ElementCollection<ISdtCellContent>, ITableRowContent, ISdtCellContent
{
  /// <summary>
  ///  Specifies the set of properties which shall be applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }
  /// <summary>
  /// Specifies the properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}