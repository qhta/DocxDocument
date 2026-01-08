namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Extension.
/// </summary>
public interface Extension: CollectionItem
{
  /// <summary>
  ///   Uniform Resource Identifier
  /// </summary>
  public string? Uri { get; set; }
}