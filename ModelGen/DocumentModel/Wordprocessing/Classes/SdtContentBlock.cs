namespace DocumentModel.Wordprocessing;


/// <summary>
///   Block-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentBlock
{
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
