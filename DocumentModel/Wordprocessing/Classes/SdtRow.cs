namespace DocumentModel.Wordprocessing;

/// <summary>
///   Row-Level Structured Document Tag.
/// </summary>
public class SdtRow: ElementCollection<ISdtRowElement>, ITableElement, ISdtContentRowElement
{
  /// <summary>
  /// Properties of structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }
  
  /// <summary>
  /// Properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }

}