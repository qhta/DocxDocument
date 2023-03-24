namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ContextMenus Class.
/// </summary>
public class ContextMenus: ModelElement
{
  public Collection<ContextMenu>? Items { get; set; }
}