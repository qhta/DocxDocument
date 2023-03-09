namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtBlock Class.
/// </summary>
public class SdtBlock: IBodyElement, ITableCellElement, ISdtContentBlockElement
{
  [XmlAnyElement] public SdtProperties? SdtProperties { get; set; }

  [XmlAnyElement] public SdtEndCharProperties? SdtEndCharProperties { get; set; }

  [XmlAnyElement] public SdtContentBlock? SdtContentBlock { get; set; }

}