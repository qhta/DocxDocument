namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the presence of a structured document tag around a single table row..
/// </summary>
public class SdtRow: ElementCollection<ISdtRowElement>, ITableElement, ISdtRowElement
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