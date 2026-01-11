namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a custom XML element surrounding a single table cell in a WordprocessingML document.
  /// This interface extends <see cref="CustomXmlElement"/>, <see cref="TableRowContent"/>, and <see cref="SdtCellContent"/>, enabling advanced schema-based processing, annotation, and integration of custom XML data within table cell content. The attributes specify the name and namespace URI of the custom XML element.
  /// </summary>
  public interface CustomXmlCell : CustomXmlElement, TableRowContent, SdtCellContent
  {
    //public TableCells TableCells { get; set; }
    //public CustomXmlCell? ChildCustomXmlCell { get; set; }
    //public SdtCell? SdtCell { get; set; }
  }