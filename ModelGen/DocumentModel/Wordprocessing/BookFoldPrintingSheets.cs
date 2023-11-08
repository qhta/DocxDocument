namespace DocumentModel.Wordprocessing;


/// <summary>
///   Number of Pages Per Booklet.
/// </summary>
public partial class BookFoldPrintingSheets: ModelElement<DXW.BookFoldPrintingSheets>
{
  public BookFoldPrintingSheets(): base(){ }
  
  public BookFoldPrintingSheets(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BookFoldPrintingSheets(DXW.BookFoldPrintingSheets openXmlElement): base(openXmlElement) { }
  
}
