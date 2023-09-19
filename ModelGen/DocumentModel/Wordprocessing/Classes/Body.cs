namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of the body of the document - the main document editing surface.
/// </summary>
public partial class Body
{
  public DocumentModel.Wordprocessing.SectionProperties? SectionProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
