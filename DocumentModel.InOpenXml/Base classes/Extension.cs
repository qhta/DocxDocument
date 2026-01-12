namespace DocumentModel;

/// <summary>
///   Represents an extension element for adding additional information to other elements.
/// </summary>
public class Extension : CollectionItem
{
  /// <summary>
  ///   URI that identifies the extension resource or schema.
  /// </summary>
  public string? Uri { get; set; }
}