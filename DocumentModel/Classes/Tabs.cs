namespace DocumentModel;

/// <summary>
///   Defines the Tabs Class.
/// </summary>
public record Tabs
{
  public Collection<Tab>? Items { get; set; }
}