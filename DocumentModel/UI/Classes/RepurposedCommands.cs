namespace DocumentModel.UI;

/// <summary>
///   Defines the RepurposedCommands Class.
/// </summary>
public record RepurposedCommands
{
  public Collection<RepurposedCommand>? Items { get; set; }
}