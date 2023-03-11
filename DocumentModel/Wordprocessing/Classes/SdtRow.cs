namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the presence of a structured document tag around a single table row..
/// </summary>
public class SdtRow: SdtElement, ITableElement, ISdtContentRowElement
{
  /// <summary>
  /// Specifies the last known contents of a structured document tag around a single table row.
  /// </summary>
  /// <remarks>
  /// Unlike other types of structured document tags, this type of structure document tag cannot show placeholder text or have mapped XML data, therefore it is never a cache.
  /// </remarks>
  [XmlContentElement] public SdtContentRow? SdtContentRow { get; set; }

}