namespace DocumentModel.UI;

/// <summary>
///   Defines the RepurposedCommands Class.
/// </summary>
public interface RepurposedCommands: IModelElement
{
  public Collection<RepurposedCommand>? Items { get; set; }
}