namespace DocumentModel.Wordprocessing;

/// <summary>
///   Cell-Level Structured Document Tag.
/// </summary>
public class SdtCell: ElementCollection<ISdtCellElement>, ITableRowElement, ISdtCellElement
{
  /// <summary>
  ///  Specifies the set of properties which shall be applied to this structured document tag.
  /// </summary>
  [XmlContentElement] public SdtProperties? SdtProperties { get; set; }

  /// <summary>
  /// Specifies the properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  [XmlContentElement] public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}