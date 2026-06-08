namespace DocumentModel.Wordprocessing;

/// <summary>
///  Represents a page number block in a text run. 
///  A page number block is a non-editable region of text 
///  which shall display the current page using ascending decimal numbers. 
///  The page number block is a legacy construct used for compatibility with older word processors, 
///  and should not be produced unless it was consumed while reading a document â€“ 
///  it is recommended Ithat the PAGENUM field is used in its place.
///  A page number block shall be displayed using ascending decimal numbers, 
///  regardless of the languages specified in the parent runâ€™s lang property .
/// </summary>
public class IPageNumber: ModelElement, IRunContent
{
}
