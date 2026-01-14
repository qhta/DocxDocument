namespace DocumentModel.Vml;

/// <summary>
///   Regroup Entry.
/// </summary>
public interface Entry: ICollectionItem
{
  /// <summary>
  ///   New Group ID
  /// </summary>
  public Int32? New { get; set; }
  /// <summary>
  ///   Old Group ID
  /// </summary>
  public Int32? Old { get; set; }
}