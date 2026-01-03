namespace DocumentModel;

/// <summary>
///   Defines the ContextMenus Class.
/// </summary>
public interface ContextMenus: IModelElement
{
  public Collection<ContextMenu>? Items { get; set; }
}