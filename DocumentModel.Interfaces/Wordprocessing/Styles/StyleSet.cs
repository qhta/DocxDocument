namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the StyleSet Class.
/// </summary>
public interface StyleSet: CollectionItem
{
  /// <summary>
  ///   id
  /// </summary>
  public UInt32? Id { get; set; }
  /// <summary>
  ///   val
  /// </summary>
  public OnOffKind? Val { get; set; }
}