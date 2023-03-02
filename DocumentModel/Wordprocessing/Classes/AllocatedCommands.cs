namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the AllocatedCommands Class.
/// </summary>
public record AllocatedCommands
{
  public Collection<AllocatedCommand>? Items { get; set; }
}