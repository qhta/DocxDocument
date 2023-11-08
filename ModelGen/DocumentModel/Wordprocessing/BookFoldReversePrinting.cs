namespace DocumentModel.Wordprocessing;


/// <summary>
///   Reverse Book Fold Printing.
/// </summary>
public partial class BookFoldReversePrinting: ModelElement<DXW.BookFoldReversePrinting>
{
  public BookFoldReversePrinting(): base(){ }
  
  public BookFoldReversePrinting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BookFoldReversePrinting(DXW.BookFoldReversePrinting openXmlElement): base(openXmlElement) { }
  
}
