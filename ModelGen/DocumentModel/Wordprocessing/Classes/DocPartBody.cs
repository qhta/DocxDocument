namespace DocumentModel.Wordprocessing;


/// <summary>
///   Contents of Glossary Document Entry.
/// </summary>
public partial class DocPartBody
{
  public SectionProperties? SectionProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
