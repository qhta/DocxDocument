namespace DocumentModel.Wordprocessing;


/// <summary>
///   Block-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentBlock
{
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
