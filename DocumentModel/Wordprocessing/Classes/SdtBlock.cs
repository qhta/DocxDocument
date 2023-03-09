namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtBlock Class.
/// </summary>
public class SdtBlock: IBodyElement, ITableCellElement, ISdtContentBlockElement
{
  [XmlContentElement] public SdtProperties? SdtProperties { get; set; }

  [XmlContentElement] public SdtEndCharProperties? SdtEndCharProperties { get; set; }

  [XmlContentElement] public SdtContentBlock? SdtContentBlock { get; set; }

}