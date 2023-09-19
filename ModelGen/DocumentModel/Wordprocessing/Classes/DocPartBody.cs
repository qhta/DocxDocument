namespace DocumentModel.Wordprocessing;


/// <summary>
///   Contents of Glossary Document Entry.
/// </summary>
public partial class DocPartBody
{
  public DocumentModel.Wordprocessing.SectionProperties? SectionProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
