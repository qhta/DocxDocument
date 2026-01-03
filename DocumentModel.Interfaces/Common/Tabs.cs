namespace DocumentModel;

/// <summary>
///   Defines the Tabs Class.
/// </summary>
public interface Tabs: IModelElement
{
  public Collection<Tab>? Items { get; set; }
}