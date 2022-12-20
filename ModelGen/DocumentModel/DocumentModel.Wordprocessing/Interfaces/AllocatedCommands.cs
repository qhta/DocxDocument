namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public partial interface AllocatedCommands
{
  public Collection<DocumentModel.Wordprocessing.AllocatedCommand>? Items { get; set; }
  
}
