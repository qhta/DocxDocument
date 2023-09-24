namespace DocumentModel.Wordprocessing;


/// <summary>
///   Inline-Level Structured Document Tag Content.
/// </summary>
public partial class SdtContentRun
{
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
