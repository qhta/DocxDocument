namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of the base text within a phonetic guide at the current location in the document.
/// </summary>
public partial class RubyBase
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
