namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single automatic captioning setting in a Wordprocessing document.
///   This class provides properties for the object identifier and the caption used for automatic captioning, enabling configuration and management of automatic captions for document objects.
/// </summary>
public class AutoCaption: CollectionItem
{
  /// <summary>
  ///   Identifier of the object to be automatically captioned.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Caption used for automatic captioning of the object.
  /// </summary>
  public string? Caption { get; set; }
}