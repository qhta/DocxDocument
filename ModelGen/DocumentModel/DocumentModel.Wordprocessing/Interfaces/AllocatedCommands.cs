namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public interface AllocatedCommands // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<AllocatedCommand>? AllocatedCommands { get ; set; }
  
}
