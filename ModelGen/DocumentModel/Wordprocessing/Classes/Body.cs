namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of the body of the document - the main document editing surface.
/// </summary>
public partial class Body
{
  public SectionProperties? SectionProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
