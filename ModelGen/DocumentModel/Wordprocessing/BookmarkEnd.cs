namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BookmarkEnd Class.
/// </summary>
public partial class BookmarkEnd: ModelElement<DXW.BookmarkEnd>
{
  public BookmarkEnd(): base(){ }
  
  public BookmarkEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BookmarkEnd(DXW.BookmarkEnd openXmlElement): base(openXmlElement) { }
  
}
