namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the presence of a custom XML element around a single table cell. 
///   The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public interface CustomXmlCell: CustomXmlElement, TableRowContent, SdtCellContent
{
  //public TableCells TableCells { get; set; }
  //public CustomXmlCell? ChildCustomXmlCell { get; set; }
  //public SdtCell? SdtCell { get; set; }
}