namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the presence of a custom XML element around one or more block level structures 
///   (paragraphs, tables, etc.). 
///   The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public interface CustomXmlBlock: CustomXmlElement, StoryContent, TableCellContent, SdtBlockContent, CommentContent
{
  //public CustomXmlBlock? ChildCustomXmlBlock { get; set; }
  //public SdtBlock? SdtBlock { get; set; }
  //public Paragraphs Paragraphs { get; set; }
  //public Tables Tables { get; set; }
}