namespace DocumentModel.Wordprocessing;


/// <summary>
///   Rich Text Box Content Container.
/// </summary>
public partial class TextBoxContent
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
