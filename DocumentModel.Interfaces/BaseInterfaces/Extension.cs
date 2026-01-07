namespace DocumentModel;

/// <summary>
///   Extension.
/// </summary>
public interface Extension: CollectionItem
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
}