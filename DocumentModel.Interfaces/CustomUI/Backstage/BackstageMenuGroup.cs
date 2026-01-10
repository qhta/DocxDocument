namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a group of menu items in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu group with properties for identification, labeling, item sizing, and access to various menu item types. It enables dynamic labeling, flexible arrangement, and comprehensive customization of Backstage menus in Office applications.
/// </remarks>
public interface BackstageMenuGroup: QualifiedElement, TaggedObject, 
  LabelledControl,
  BackstageMenuGroupContentCollection
{

  /// <summary>
  /// Item size for menu items in the group.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

}