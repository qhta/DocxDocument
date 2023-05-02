namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Tabs Class.
/// </summary>
public class Tabs: ModelElement
{
  public Collection<Tab>? Items { get; set; }
}