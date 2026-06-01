namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ICell-Level Structured IDocument Tag.
/// </summary>
public class SdtCell: ElementCollection<ISdtCellContent>, ITableRowContent, ISdtCellContent
{
  /// <summary>
  ///  Specifies the set of properties which shall be applied Ito this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }

  /// <summary>
  /// Specifies the properties which shall be applied Ito the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}
