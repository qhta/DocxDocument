namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definitions.
/// </summary>
public partial class Numbering
{
  public Int32? NumberingIdMacAtCleanup { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
