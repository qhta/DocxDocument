namespace DocumentModel.Wordprocessing;


/// <summary>
///   Book Fold Printing.
/// </summary>
public partial class BookFoldPrinting: ModelElement<DXW.BookFoldPrinting>
{
  public BookFoldPrinting(): base(){ }
  
  public BookFoldPrinting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BookFoldPrinting(DXW.BookFoldPrinting openXmlElement): base(openXmlElement) { }
  
}
