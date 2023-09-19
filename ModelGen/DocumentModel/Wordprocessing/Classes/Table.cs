namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a table present in the document. A table is a set of paragraphs (and other block-level content) arranged in rows and columns. Tables in WordprocessingML are defined via the tbl element, which is analogous to the HTML table tag.
/// </summary>
public partial class Table
{
  public DocumentModel.Wordprocessing.TableProperties? TableProperties { get; set; }
  
  public DocumentModel.Wordprocessing.TableGrid? TableGrid { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
