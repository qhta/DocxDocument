namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Types.
/// </summary>
public partial class DocPartTypes
{
  
  /// <summary>
  ///   Entry Is Of All Types
  /// </summary>
  public Boolean? All { get; set; }
  
  public DM.ElementCollection<DocPartKind>? Items { get; set; }
  
}
