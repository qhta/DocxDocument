namespace DocumentModel.CustomUI;

/// <summary>
/// Represents an item type in the Office Backstage view, supporting dynamic labeling and identification for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage item type with properties for identification and labeling. It enables dynamic label text and supports collection-based organization for advanced Backstage customization in Office applications.
/// </remarks>
public interface BackstageItemType : IdentifiedElement, CollectionItem
{

  /// <summary>
  /// Label text for the Backstage item type.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }
}