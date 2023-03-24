using DocumentModel.UI;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.).
/// </summary>
public class SdtBlock: ElementCollection<ISdtBlockElement>, IBodyElement, ITableCellElement, ISdtBlockElement
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