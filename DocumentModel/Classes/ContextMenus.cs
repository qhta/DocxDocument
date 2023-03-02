namespace DocumentModel;

/// <summary>
///   Defines the ContextMenus Class.
/// </summary>
public record ContextMenus
{
  public Collection<ContextMenu>? Items { get; set; }
}