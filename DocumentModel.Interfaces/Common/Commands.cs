namespace DocumentModel;

/// <summary>
///   Defines the Commands Class.
/// </summary>
public interface Commands: IModelElement
{
  public Collection<Command>? Items { get; set; }
}