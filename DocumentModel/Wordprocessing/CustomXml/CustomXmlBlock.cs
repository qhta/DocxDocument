namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the presence of a custom XML element around one or more block level structures 
///   (paragraphs, tables, etc.). 
///   The attributes on this element shall be used Ito specify the name and namespace URI of the current custom XML element.
/// </summary>
public class CustomXmlBlock: CustomXmlElement, IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent
{
  //public CustomXmlBlock? ChildCustomXmlBlock { get; set; }

  //public SdtBlock? SdtBlock { get; set; }

  //public Collection<IParagraph>? IParagraphs { get; set; }

  //public Collection<ITable>? ITables { get; set; }

}
