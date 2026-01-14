namespace DocumentModel;

/// <summary>
///   Represents an extension element for adding additional information to other elements.
/// </summary>
public interface IExtension : ICollectionItem
{
  /// <summary>
  ///   UriString that identifies the extension resource or schema.
  /// </summary>
  public string? UriString { get; set; }
}