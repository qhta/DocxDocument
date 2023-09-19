namespace DocumentModel.Wordprocessing;


/// <summary>
///   Block-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentBlock
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
