namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the RepurposedCommands Class.
/// </summary>
public class RepurposedCommands: ModelElement
{
  public Collection<RepurposedCommand>? Items { get; set; }
}
