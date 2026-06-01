namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Commands Class.
/// </summary>
public class Commands: ModelElement
{
  public Collection<Command>? Items { get; set; }
}
