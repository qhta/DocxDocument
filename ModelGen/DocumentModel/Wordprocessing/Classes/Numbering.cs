namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definitions.
/// </summary>
public partial class Numbering
{
  public Int32? NumberingIdMacAtCleanup { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
