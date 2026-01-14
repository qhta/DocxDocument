namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabel Class.
/// </summary>
public interface ClassificationLabel: ICollectionItem
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }
  /// <summary>
  ///   setDate
  /// </summary>
  public string? SetDate { get; set; }
  /// <summary>
  ///   method
  /// </summary>
  public string? Method { get; set; }
  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   siteId
  /// </summary>
  public string? SiteId { get; set; }
  /// <summary>
  ///   actionId
  /// </summary>
  public string? ActionId { get; set; }
  /// <summary>
  ///   contentBits
  /// </summary>
  public UInt32? ContentBits { get; set; }
  /// <summary>
  ///   removed
  /// </summary>
  public bool? Removed { get; set; }
}