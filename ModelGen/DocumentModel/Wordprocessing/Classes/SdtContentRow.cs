namespace DocumentModel.Wordprocessing;


/// <summary>
///   Row-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentRow
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
