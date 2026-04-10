namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a position that delimited the end of a page 
///   when this document was last saved by an application which paginates its content. 
/// </summary>
[OpenXmlType(typeof(DXW.LastRenderedPageBreak))]
[XmlRoot("LastRenderedPageBreak", Namespace = "DocumentModel.Wordprocessing")]
public class LastRenderedPageBreak : ModelElement<DXW.LastRenderedPageBreak>, IRunContent
{
}