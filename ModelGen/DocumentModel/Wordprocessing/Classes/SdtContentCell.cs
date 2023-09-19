namespace DocumentModel.Wordprocessing;


/// <summary>
///   Cell-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentCell
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
