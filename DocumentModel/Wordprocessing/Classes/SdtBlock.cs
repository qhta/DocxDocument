using DocumentModel.UI;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.).
/// </summary>
public class SdtBlock: SdtElement, IBodyElement, ITableCellElement, ISdtContentBlockElement
{
  /// <summary>
  /// Specifies the last known contents of a structured document tag around one or more block-level structures (paragraphs, tables, etc.). 
  /// This element's contents shall be treated as a cache of the contents to be displayed in the structured document tag for the following reasons:
  /// <list type="bullet">
  ///   <item>
  ///     If the structured document tag specifies an XML mapping via the dataBinding element,
  ///     changes to the custom XML data part shall be reflected in the structured document tag as needed
  ///   </item>
  ///   <item>
  ///     If the contents of the structured document tag are placeholder text via the showingPlcHdr element,
  ///     then this content can be updated with the placeholder text stored in the Glossary Document part
  ///   </item>
  /// </list>
  /// </summary>
  [XmlContentElement] public SdtContentBlock? SdtContentBlock { get; set; }

}