namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a group of menu items in the Office Backstage view, supporting dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage menu group with properties for identification, labeling, item sizing, and access to various menu item types. It enables dynamic labeling, flexible arrangement, and comprehensive customization of Backstage menus in Office applications.
/// </remarks>
public interface BackstageMenuGroup: QualifiedElement, TaggedObject
{

  /// <summary>
  /// Label text for the menu group.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Item size for menu items in the group.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  /// <summary>
  /// Menu button item in the group.
  /// </summary>
  public BackstageMenuButton? BackstageMenuButton { get; set; }

  /// <summary>
  /// Menu checkbox item in the group.
  /// </summary>
  public BackstageMenuCheckBox? BackstageMenuCheckBox { get; set; }

  /// <summary>
  /// Submenu item in the group.
  /// </summary>
  public BackstageSubMenu? BackstageSubMenu { get; set; }

  /// <summary>
  /// Menu toggle button item in the group.
  /// </summary>
  public BackstageMenuToggleButton? BackstageMenuToggleButton { get; set; }
}